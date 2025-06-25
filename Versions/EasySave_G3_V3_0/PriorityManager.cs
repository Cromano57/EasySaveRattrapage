using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasySave_G3_V3_0
{
    public class PriorityManager
    {
        private readonly HashSet<string> _priorityExts;   // extensions with high prio

        private int _pendingCount = 0;                    

        private TaskCompletionSource<bool> _tcs =
            new(TaskCreationOptions.RunContinuationsAsynchronously);

        private readonly object _lock = new();          
        public PriorityManager(IEnumerable<string> priorityExtensions)
        {
            _priorityExts = new HashSet<string>(
                priorityExtensions.Select(ext =>
                    ext.StartsWith('.') ? ext.ToLower() : "." + ext.ToLower()));
        }


        public void RegisterPendingFiles(IEnumerable<string> filePaths)
        {
            int add = filePaths.Count(path =>
                _priorityExts.Contains(Path.GetExtension(path).ToLower()));
            if (add == 0) return;
            if (Volatile.Read(ref _pendingCount) == 0)
            {
                lock (_lock)
                {
                    if (_pendingCount == 0)             
                        _tcs = new(TaskCreationOptions.RunContinuationsAsynchronously);
                }
            }

            Interlocked.Add(ref _pendingCount, add);   
        }

        public Task WaitIfNonPriorityAsync(string filePath)
        {
            string ext = Path.GetExtension(filePath).ToLower();
            if (!_priorityExts.Contains(ext) && Volatile.Read(ref _pendingCount) > 0)
                return _tcs.Task;        

            return Task.CompletedTask;   
        }

        public void SignalPriorityFileDone(string filePath)
        {
            string ext = Path.GetExtension(filePath).ToLower();
            if (!_priorityExts.Contains(ext)) return;   

            if (Interlocked.Decrement(ref _pendingCount) == 0)
                _tcs.TrySetResult(true);
        }
    }
}
