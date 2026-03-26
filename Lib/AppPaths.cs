namespace VModManager.Lib
{
    public static class AppPaths
    {
        public static string BaseFolder =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "VModManager");

        public static string SettingsFile => Path.Combine(BaseFolder, "settings.json");
        public static string PresetsFile => Path.Combine(BaseFolder, "presets.json");
        public static string LibraryFolder => Path.Combine(BaseFolder, "Library");

        public static void EnsureCreated()
        {
            Directory.CreateDirectory(BaseFolder);
            Directory.CreateDirectory(LibraryFolder);
        }
    }
}
