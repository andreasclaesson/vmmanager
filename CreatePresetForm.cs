using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace VModManager
{
    public partial class CreatePresetForm : MaterialSkin.Controls.MaterialForm
    {
        public string PresetName => txtPresetName.Text.Trim();
        public List<string> SelectedFiles { get; private set; } = new();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DataFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Base");

        public CreatePresetForm()
        {
            InitializeComponent();
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
            LoadAvailableFiles();
        }

        private void LoadAvailableFiles()
        {
            if (!Directory.Exists(DataFolder))
                Directory.CreateDirectory(DataFolder);

            chkFiles.Items.Clear();

            // Load both .dll and .asi files
            var files = Directory.EnumerateFiles(DataFolder)
                                 .Where(f => f.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) ||
                                             f.EndsWith(".asi", StringComparison.OrdinalIgnoreCase))
                                 .Select(Path.GetFileName)
                                 .ToList();

            foreach (var f in files)
                chkFiles.Items.Add(f, false);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PresetName))
            {
                MessageBox.Show("Enter a preset name.");
                return;
            }

            SelectedFiles = new List<string>();
            foreach (var item in chkFiles.CheckedItems)
                SelectedFiles.Add(item.ToString());

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}