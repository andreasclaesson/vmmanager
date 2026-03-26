using System;
using System.Collections.Generic;
using System.Text;

namespace VModManager.Lib
{
    public class Preset
    {
        public string Name { get; set; }
    }

    public class Settings
    {
        public string GtaPath { get; set; }
        public string LibraryPath { get; set; }
        public string ActivePreset { get; set; } = string.Empty;
    }
}