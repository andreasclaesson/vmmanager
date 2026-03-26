namespace VModManager.Lib
{
    public class FileManager
    {
        public void ApplyPreset(Preset preset, string gtaPath, string libraryPath)
        {
            string presetPath = Path.Combine(libraryPath, preset.Name);

            if (!Directory.Exists(presetPath))
                throw new Exception("Preset folder not found");

            string[] extensions = { "*.asi", "*.dll", "*.ini", "*.json" };

            foreach (var ext in extensions)
            {
                foreach (var file in Directory.GetFiles(gtaPath, ext))
                    File.Delete(file);
            }

            string scriptsPath = Path.Combine(gtaPath, "scripts");
            if (Directory.Exists(scriptsPath))
                Directory.Delete(scriptsPath, true);

            foreach (var file in Directory.GetFiles(presetPath))
            {
                string dest = Path.Combine(gtaPath, Path.GetFileName(file));
                File.Copy(file, dest, true);
            }

            string scriptsSource = Path.Combine(presetPath, "scripts");
            if (Directory.Exists(scriptsSource))
            {
                CopyDirectory(scriptsSource, scriptsPath);
            }
        }

        private void CopyDirectory(string source, string dest)
        {
            Directory.CreateDirectory(dest);

            foreach (var file in Directory.GetFiles(source))
            {
                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)), true);
            }

            foreach (var dir in Directory.GetDirectories(source))
            {
                CopyDirectory(dir, Path.Combine(dest, Path.GetFileName(dir)));
            }
        }
    }
}
