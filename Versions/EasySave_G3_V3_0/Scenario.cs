using EasySave.Core;
using EasySave_G3_V3_0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace EasySave_G3_V1
{
    public class Scenario : INotifyPropertyChanged
    {

        private static readonly PriorityManager PrioMgr =
            new(new ParametersManager().Parametres.ExtensionsPrioritaires);


        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public BackupType Type { get; set; }
        public BackupState State { get; set; }
        public string Description { get; set; }
        public bool IsSelected { get; set; }
        public LogEntry Log { get; set; }


        public int GetId() => Id;
        public void SetId(int v) => Id = v;
        public string GetName() => Name;
        public void SetName(string v) => Name = v;
        public string GetSource() => Source;
        public void SetSource(string v) => Source = v;
        public string GetTarget() => Target;
        public void SetTarget(string v) => Target = v;
        public BackupType GetSceanrioType() => Type;
        public void SetType(BackupType v) => Type = v;
        public BackupState GetState() => State;
        public void SetState(BackupState v) => State = v;
        public string GetDescription() => Description;
        public void SetDescription(string v) => Description = v;
        public LogEntry GetLog() => Log;
        public void SetLog(LogEntry v) => Log = v;

        /* Progress (%) for the WPF progress-bar */
        private double _progress;
        public double Progress
        {
            get => _progress;
            private set { _progress = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        #region ----- Constructors -----
        public Scenario()
        {
            Id = -1;
            Name = string.Empty;
            Source = string.Empty;
            Target = string.Empty;
            Type = BackupType.Full;
            State = BackupState.Pending;
            Description = string.Empty;
            IsSelected = false;
            Log = new LogEntry();
            _progress = 0;
        }

        public Scenario(int id, string name, string source, string target,
                        BackupType type, string description) : this()
        {
            Id = id;
            Name = name;
            Source = source;
            Target = target;
            Type = type;
            Description = description;
        }
        #endregion


        public List<string> Execute()
        {
            var messages = new List<string>();
            try
            {
                State = BackupState.Running;
                messages.Add($"Backup '{Name}' is running…");

                string? result = null;
                var t = new Thread(() => result = RunSave()); 
                t.Start();
                t.Join();

                if (!string.IsNullOrWhiteSpace(result))
                    messages.Add(result);

                State = BackupState.Completed;
                messages.Add($"Backup '{Name}' completed successfully.");
            }
            catch (Exception ex)
            {
                State = BackupState.Failed;
                messages.Add($"Error during backup '{Name}': {ex.Message}");
            }
            return messages;
        }

        private static bool IsBusinessSoftwareRunning()
        {
            try
            {
                const string settingsPath = "settings.json";
                if (!File.Exists(settingsPath)) return false;

                using var doc = JsonDocument.Parse(File.ReadAllText(settingsPath));
                if (!doc.RootElement.TryGetProperty("CheminsLogiciels", out var arr) ||
                    arr.ValueKind != JsonValueKind.Array)
                    return false;

                foreach (var elem in arr.EnumerateArray())
                {
                    string? exe = elem.GetString();
                    if (string.IsNullOrWhiteSpace(exe)) continue;
                    string name = Path.GetFileNameWithoutExtension(exe)!.ToLower();
                    if (Process.GetProcessesByName(name).Any())
                        return true;
                }
            }
            catch {  }
            return false;
        }


        private string RunSave()
        {
            try
            {
                var swTotal = Stopwatch.StartNew();

                if (IsBusinessSoftwareRunning())
                    return "Backup blocked: a business software is currently running.";
                if (!Directory.Exists(Source))
                    return $"Source path '{Source}' not found.";
                if (!Directory.Exists(Target))
                    return $"Target path '{Target}' not found.";

                var pm = new ParametersManager();
                Enum.TryParse(pm.Parametres.FormatLog, true, out LogFormat logFormat);
                if (logFormat == 0) logFormat = LogFormat.Json;

                var toEncrypt = pm.Parametres.ExtensionsChiffrees
                                  .Select(e => e.StartsWith(".") ? e.ToLower() : "." + e.ToLower())
                                  .ToHashSet();

                var prioExt = pm.Parametres.ExtensionsPrioritaires
                                  .Select(e => e.StartsWith(".") ? e.ToLower() : "." + e.ToLower())
                                  .ToHashSet();

                var allFiles = Directory
                    .GetFiles(Source, "*", SearchOption.AllDirectories)
                    .OrderBy(f => prioExt.Contains(Path.GetExtension(f).ToLower()) ? 0 : 1)
                    .ToList();

                PrioMgr.RegisterPendingFiles(allFiles);

                var folders = new List<Folder>();
                string key = "cle123";  // TODO: move to serparated file
                int total = allFiles.Count, done = 0;

                foreach (string src in allFiles)
                {
                    bool isPrio = prioExt.Contains(Path.GetExtension(src).ToLower());

 
                    if (!isPrio)
                        PrioMgr.WaitIfNonPriorityAsync(src).Wait();

                    Thread.Sleep(1000);   // delay to see the progress bar filling step by step

                    string rel = Path.GetRelativePath(Source, src);
                    string dst = Path.Combine(Target, rel);
                    Directory.CreateDirectory(Path.GetDirectoryName(dst)!);

                    bool shouldCopy = Type switch
                    {
                        BackupType.Full => true,
                        BackupType.Differential => !File.Exists(dst) ||
                                                   File.GetLastWriteTimeUtc(src) > File.GetLastWriteTimeUtc(dst),
                        _ => false
                    };

                    long encTimeMs = 0;
                    if (shouldCopy)
                    {
                        File.Copy(src, dst, true);
                        int encResult = EncryptIfNeeded(dst, key);
                        encTimeMs = encResult;
                    }


                    var fi = new FileInfo(src);
                    var entry = new Folder(src, fi.LastWriteTime, fi.Name, true, fi.Length);
                    entry.SetEncryptionTimeMs(encTimeMs);
                    folders.Add(entry);

      
                    if (isPrio)
                        PrioMgr.SignalPriorityFileDone(src);


                    done++;
                    Progress = 100.0 * done / total;
                }

                swTotal.Stop();


                Log = new LogEntry(DateTime.Now, Name, Type, Source, Target,
                                   folders.Count, (int)swTotal.ElapsedMilliseconds,
                                   State, folders);
                Log.SetDurationMs((int)swTotal.ElapsedMilliseconds);
                Log.AppendToFile(logFormat);

                return "done";
            }
            catch (Exception ex)
            {
                return $"Une erreur est survenue pendant la sauvegarde : {ex.Message}";
            }
        }


        private static int EncryptIfNeeded(string filePath, string encryptionKey)
        {
            if (!File.Exists(filePath)) return 0;

            var pm = new ParametersManager();
            var toEncrypt = pm.Parametres.ExtensionsChiffrees
                               .Select(e => e.StartsWith(".") ? e.ToLower() : "." + e.ToLower())
                               .ToHashSet();

            string ext = Path.GetExtension(filePath).ToLower();
            if (!toEncrypt.Contains(ext)) return 0;

            const int retryDelayMs = 500;
            const int maxRetries = 120;

            for (int a = 0; a < maxRetries; a++)
            {
                int exitCode = LaunchCryptoSoft(filePath, encryptionKey);

                if (exitCode >= 0)                   
                    return exitCode;
                if (exitCode is -1 or -99)         
                    return -1;


                Thread.Sleep(retryDelayMs);
            }
            return -1; 
        }


        private static int LaunchCryptoSoft(string filePath, string key)
        {
            string exe = Path.Combine(AppContext.BaseDirectory, "CryptoSoft.exe");

            var p = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = exe,
                    Arguments = $"\"{filePath}\" {key}",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };

            p.Start();
            p.WaitForExit();
            Debug.WriteLine($"[Encrypt] CryptoSoft exit = {p.ExitCode}");
            return p.ExitCode;
        }

        public string Cancel()
        {
            if (State == BackupState.Running)
            {
                State = BackupState.Cancelled;
                return $"Backup '{Name}' has been cancelled.";
            }
            return $"Cannot cancel backup '{Name}' as it is not currently running.";
        }

        public Task<List<string>> ExecuteAsync()
            => Task.Run(() => Execute());
    }
}
