using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace VModManager.Lib
{
    public class PresetManager
    {
        private readonly string path = AppPaths.PresetsFile;

        public List<Preset> Load()
        {
            if (!File.Exists(path))
                return new List<Preset>();

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Preset>>(json) ?? new List<Preset>();
        }

        public void Save(List<Preset> presets)
        {
            string json = JsonSerializer.Serialize(presets, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public List<Preset> LoadOrRebuildFromLibrary(string libraryPath)
        {
            List<Preset> presets = Load();

            if (presets != null && presets.Count > 0)
                return presets;

            if (!Directory.Exists(libraryPath))
                return new List<Preset>();

            var folders = Directory.GetDirectories(libraryPath);

            presets = folders.Select(f => new Preset
            {
                Name = Path.GetFileName(f)
            }).ToList();
            Save(presets);

            return presets;
        }
    }
}
