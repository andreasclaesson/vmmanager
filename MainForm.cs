using MaterialSkin;
using MaterialSkin.Controls;
using VModManager.Lib;
using VModManager.Services;

namespace VModManager
{
    public partial class MainForm : MaterialForm
    {
        private Preset activePreset;
        private PresetManager presetManager = new();
        private SettingsService settingsService = new();
        private FileManager fileManager = new();

        private List<Preset> presets = new();
        private Settings settings;

        public MainForm()
        {
            AppPaths.EnsureCreated();
            InitializeComponent();
            settings = settingsService.Load();
            if (string.IsNullOrEmpty(settings.LibraryPath))
            {
                settings.LibraryPath = AppPaths.LibraryFolder;
                settingsService.Save(settings);
            }

            presets = presetManager.LoadOrRebuildFromLibrary(settings.LibraryPath);
            if (presets.Count == 0)
            {
                AddPreset("Vanilla");
            }

            RefreshPresetList();
            if (!string.IsNullOrEmpty(settings.ActivePreset))
            {
                var preset = presets.FirstOrDefault(p => p.Name == settings.ActivePreset);
                if (preset != null)
                {
                    activePreset = preset;
                    this.BeginInvoke(new Action(() =>
                    {
                        presetListBox.SelectedItem = preset.Name;
                        lblActivePreset.Text = $"Active: {preset.Name}";
                    }));
                }
            }

            var skinManager = MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = true;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void RefreshPresetList()
        {
            presetListBox.Items.Clear();
            foreach (var p in presets)
                presetListBox.Items.Add(p.Name);
        }

        private void DetectConflicts(string presetPath)
        {
            var files = Directory.GetFiles(presetPath)
                .Select(Path.GetFileName)
                .ToList();

            var duplicates = files
                .GroupBy(f => f)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

            if (duplicates.Any())
            {
                MessageBox.Show("Duplicate files in preset:\n" + string.Join("\n", duplicates));
            }
        }

        private bool ValidatePaths()
        {
            if (string.IsNullOrEmpty(settings.GtaPath) || !Directory.Exists(settings.GtaPath))
            {
                MessageBox.Show("GTA V folder is not set or invalid. Please configure it in Settings.");
                return false;
            }

            if (string.IsNullOrEmpty(settings.LibraryPath) || !Directory.Exists(settings.LibraryPath))
            {
                MessageBox.Show("Library folder is not set or invalid. Please configure it in Settings.");
                return false;
            }

            return true;
        }

        private void AddPreset(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return;

            if (presets.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A preset with that name already exists.");
                return;
            }

            var preset = new Preset { Name = name };
            presets.Add(preset);

            string presetPath = Path.Combine(settings.LibraryPath, name);
            Directory.CreateDirectory(presetPath);

            presetManager.Save(presets);

            RefreshPresetList();
            presetListBox.SelectedItem = name;
        }

        private void LoadPresetFiles(Preset preset)
        {
            filesListBox.Items.Clear();

            string presetPath = Path.Combine(settings.LibraryPath, preset.Name);

            if (!Directory.Exists(presetPath)) return;

            foreach (var file in Directory.GetFiles(presetPath))
            {
                filesListBox.Items.Add(Path.GetFileName(file));
            }
        }

        private Preset GetSelectedPreset()
        {
            return presets.FirstOrDefault(p => p.Name == presetListBox.SelectedItem?.ToString());
        }

        private void presetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var preset = GetSelectedPreset();
            if (preset == null) return;

            presetNameTextBox.Text = preset.Name;

            LoadPresetFiles(preset);
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedPreset();
            if (preset == null)
            {
                MessageBox.Show("Select a preset first!");
                return;
            }

            using var dlg = new OpenFileDialog
            {
                Title = "Add Mod File",
                Filter = "ASI files (*.asi)|*.asi|DLL files (*.dll)|*.dll|All files (*.*)|*.*",
                Multiselect = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string presetPath = Path.Combine(settings.LibraryPath, preset.Name);
                Directory.CreateDirectory(presetPath); // ensure folder exists

                foreach (string f in dlg.FileNames)
                {
                    string fileName = Path.GetFileName(f);
                    string dest = Path.Combine(presetPath, fileName);

                    File.Copy(f, dest, true); // copy actual file to preset folder

                    if (!filesListBox.Items.Contains(fileName))
                        filesListBox.Items.Add(fileName);
                }
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedPreset();
            if (preset == null) return;

            if (filesListBox.SelectedItem == null) return;

            string fileName = filesListBox.SelectedItem.ToString();
            string filePath = Path.Combine(settings.LibraryPath, preset.Name, fileName);

            if (File.Exists(filePath))
                File.Delete(filePath); // remove actual file

            filesListBox.Items.Remove(filesListBox.SelectedItem); // remove from UI
        }

        private void btnCreatePreset_Click(object sender, EventArgs e)
        {
            using var form = new CreatePresetForm();
            form.DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Base"); // optional

            if (form.ShowDialog() == DialogResult.OK)
            {
                string name = form.PresetName;
                if (presets.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("A preset with that name already exists.");
                    return;
                }

                AddPreset(name);

                var presetPath = Path.Combine(settings.LibraryPath, name);

                // Copy selected files from Data folder to preset folder
                foreach (string file in form.SelectedFiles)
                {
                    string src = Path.Combine(form.DataFolder, file);
                    string dest = Path.Combine(presetPath, file);
                    File.Copy(src, dest, true);
                }

                LoadPresetFiles(GetSelectedPreset());
                MessageBox.Show($"Preset '{name}' created successfully!");
            }
        }

        private void btnDeletePreset_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedPreset();
            if (preset == null) return;

            presets.Remove(preset);

            string presetPath = Path.Combine(settings.LibraryPath, preset.Name);
            if (Directory.Exists(presetPath))
                Directory.Delete(presetPath, true);

            presetManager.Save(presets);

            RefreshPresetList();

            filesListBox.Items.Clear();
            presetNameTextBox.Text = "";
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedPreset();
            if (preset == null) return;

            string oldPath = Path.Combine(settings.LibraryPath, preset.Name);
            string newName = presetNameTextBox.Text.Trim();
            string newPath = Path.Combine(settings.LibraryPath, newName);

            if (!string.Equals(preset.Name, newName, StringComparison.OrdinalIgnoreCase))
            {
                if (Directory.Exists(oldPath))
                    Directory.Move(oldPath, newPath);

                preset.Name = newName;
            }

            presetManager.Save(presets);
            RefreshPresetList();
            presetListBox.SelectedItem = newName;

            MessageBox.Show("Saved!");
        }

        private void btnApplyPreset_Click(object sender, EventArgs e)
        {
            if (!ValidatePaths())
                return;

            var preset = GetSelectedPreset();
            if (preset == null) return;

            string presetPath = Path.Combine(settings.LibraryPath, preset.Name);
            DetectConflicts(presetPath);

            try
            {
                fileManager.ApplyPreset(preset, settings.GtaPath, settings.LibraryPath);

                activePreset = preset;
                lblActivePreset.Text = $"Active: {preset.Name}";
                LoggerService.Log($"Applied preset: {preset.Name}");

                settings.ActivePreset = preset.Name;
                settingsService.Save(settings);

                MessageBox.Show("Preset applied!");
            }
            catch (Exception ex)
            {
                LoggerService.Log(ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using var form = new SettingsForm(settings, settingsService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                presets = presetManager.Load();
                RefreshPresetList();
            }
        }

        private void btnExportPreset_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedPreset();
            if (preset == null)
            {
                MessageBox.Show("Select a preset first!");
                return;
            }

            string presetPath = Path.Combine(settings.LibraryPath, preset.Name);

            using var dlg = new SaveFileDialog
            {
                Filter = "Preset Package (*.vmpreset)|*.vmpreset",
                FileName = preset.Name
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dlg.FileName))
                    File.Delete(dlg.FileName);

                System.IO.Compression.ZipFile.CreateFromDirectory(presetPath, dlg.FileName);

                MessageBox.Show("Preset exported!");
            }
        }

        private void btnImportPreset_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Filter = "Preset Package (*.vmpreset)|*.vmpreset"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string tempFolder = Path.Combine(Path.GetTempPath(), $"VModImport_{Guid.NewGuid()}");

                if (Directory.Exists(tempFolder))
                    Directory.Delete(tempFolder, true);

                System.IO.Compression.ZipFile.ExtractToDirectory(dlg.FileName, tempFolder);

                string presetName = Path.GetFileNameWithoutExtension(dlg.FileName);
                string destPath = Path.Combine(settings.LibraryPath, presetName);

                if (Directory.Exists(destPath))
                {
                    MessageBox.Show("Preset already exists!");
                    return;
                }

                Directory.Move(tempFolder, destPath);

                presets = presetManager.Load();
                presets.Add(new Preset { Name = presetName });
                presetManager.Save(presets);

                RefreshPresetList();

                MessageBox.Show("Preset imported!");
            }
        }
    }
}
