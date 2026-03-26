using System.Text.Json;
using VModManager.Lib;

namespace VModManager.Services
{
    public class SettingsService
    {
        private readonly string path = AppPaths.SettingsFile;

        public Settings Load()
        {
            if (!File.Exists(path))
                return new Settings();

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Settings>(json);
        }

        public void Save(Settings settings)
        {
            Directory.CreateDirectory("Data");

            string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }
}
