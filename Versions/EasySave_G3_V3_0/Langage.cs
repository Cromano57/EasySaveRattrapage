using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EasySave_G3_V1
{
    public class Langage
    {

        private string Title;                       
        private string Source;                   
        private readonly Dictionary<string, string> Elements;

  
        public Langage()
        {
            Elements = new Dictionary<string, string>();

            try
            {
                
                using FileStream fs = File.OpenRead("settings.json");
                using JsonDocument doc = JsonDocument.Parse(fs);

                
                JsonElement root = doc.RootElement;
                if (root.TryGetProperty("Langue", out JsonElement langueElement))
                {
                    Title = langueElement.GetString();
                    Source = $"Langages/{Title}.json";  
                }
                else
                {
                    // Fallback to French
                    Title = "Français";
                    Source = "Langages/Français.json";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error reading settings.json: {e.Message}");
                Title = "Français";
                Source = "Langages/Français.json";
            }
        }

        public Langage(string title, string source)
        {
            Title = title;
            Source = source;
            Elements = new Dictionary<string, string>();
        }


        public string GetTitle() => Title;
        public string GetSource() => Source;
        public void SetTitle(string title) => Title = title;
        public void SetSource(string src) => Source = src;
        public Dictionary<string, string> GetElements() => Elements;

        public void AddElement(Dictionary<string, string> element)
        {
            foreach (var kvp in element)
                Elements[kvp.Key] = kvp.Value;
        }


        public string LoadLangage()
        {
            try
            {
                string jsonContent = File.ReadAllText(Source);
                var messages = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonContent);

                if (messages is not null)
                    AddElement(messages);

                return "";           
            }
            catch (Exception e)
            {
                return e.Message;    
            }
        }
    }
}
