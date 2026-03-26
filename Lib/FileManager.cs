namespace VModManager.Lib
{
    public class FileManager
    {
        public void ApplyPreset(Preset newPreset, Preset oldPreset, string gtaPath, string libraryPath)
        {
            if (oldPreset != null)
            {
                string oldPresetPath = Path.Combine(libraryPath, oldPreset.Name);
                if (Directory.Exists(oldPresetPath))
                {
                    var oldFiles = Directory.GetFiles(oldPresetPath)
                        .Select(Path.GetFileName);

                    foreach (var fileName in oldFiles)
                    {
                        string target = Path.Combine(gtaPath, fileName);
                        if (File.Exists(target))
                        {
                            File.Delete(target);
                        }
                    }

                    string oldScripts = Path.Combine(oldPresetPath, "scripts");
                    string gtaScripts = Path.Combine(gtaPath, "scripts");
                    if (Directory.Exists(oldScripts) && Directory.Exists(gtaScripts))
                    {
                        Directory.Delete(oldScripts);
                    }
                }
            }

            string newPresetPath = Path.Combine(libraryPath, newPreset.Name);
            if (!Directory.Exists(newPresetPath)) 
                throw new Exception("Preset directory does not exist.");

            foreach (var file in Directory.GetFiles(newPresetPath))
            {
                string dest = Path.Combine(gtaPath, Path.GetFileName(file));
                File.Copy(file, dest, true);
            }

            string scriptsSource = Path.Combine(newPresetPath, "scripts");
            string scriptsDest = Path.Combine(gtaPath, "scripts");
            if (Directory.Exists(scriptsSource))
            {
                CopyDirectory(scriptsSource, scriptsDest);
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
