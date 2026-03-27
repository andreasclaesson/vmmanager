using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.IO.Compression;
using VModManager.Lib;
using VModManager.Services;

namespace VModManager
{
    public partial class SettingsForm : MaterialForm
    {
        private Settings settings;
        private SettingsService settingsService;

        public SettingsForm(Settings settings, SettingsService settingsService)
        {
            InitializeComponent();
            this.settings = settings;
            this.settingsService = settingsService;

            txtGTAFolder.Text = settings.GtaPath ?? "";
            txtLibrary.Text = settings.LibraryPath ?? "";
            lblVersionText.Text = $"Version: {AppVersion.Version}";

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

        private void btnBrowseGTA_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog { Description = "Select GTA V Folder" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtGTAFolder.Text = dlg.SelectedPath;
            }
        }

        private void btnBrowseLibrary_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog { Description = "Select Mod Library Folder" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLibrary.Text = dlg.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings.GtaPath = txtGTAFolder.Text;
            settings.LibraryPath = txtLibrary.Text;

            settingsService.Save(settings);

            DialogResult = DialogResult.OK;
            Close();
        }

        private async void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            var updater = new UpdateService();
            var result = await updater.CheckForUpdateAsync(AppVersion.Version);

            if (!result.hasUpdate)
            {
                MessageBox.Show("You're up to date!");
                return;
            }

            if (MessageBox.Show($"Update {result.version} found. Install?",
                "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                await DownloadAndRunUpdater(result.url);
            }
        }

        private async Task DownloadAndRunUpdater(string url)
        {
            string tempZip = Path.Combine(Path.GetTempPath(), $"vmod_update_{Guid.NewGuid()}.zip");

            using var client = new HttpClient();
            var data = await client.GetByteArrayAsync(url);
            await File.WriteAllBytesAsync(tempZip, data);

            string appDir = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\');

            string updaterPath = Path.Combine(appDir, "VModUpdater.exe");

            if (!File.Exists(updaterPath))
            {
                MessageBox.Show("Updater not found!");
                return;
            }

            var psi = new ProcessStartInfo
            {
                FileName = updaterPath,
                UseShellExecute = false
            };
            psi.ArgumentList.Add(tempZip);
            psi.ArgumentList.Add(appDir);
            psi.ArgumentList.Add("VModManager.exe");
            psi.ArgumentList.Add(Environment.ProcessId.ToString());

            try
            {
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start updater:\n{ex}");
                return;
            }

            Application.Exit();
        }
    }
}
