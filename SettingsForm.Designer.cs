namespace VModManager
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialTextBox2 txtGTAFolder;
        private MaterialSkin.Controls.MaterialButton btnBrowseGTA;
        private MaterialSkin.Controls.MaterialTextBox2 txtLibrary;
        private MaterialSkin.Controls.MaterialButton btnBrowseLibrary;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Panel pnlPaths;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtGTAFolder = new MaterialSkin.Controls.MaterialTextBox2();
            btnBrowseGTA = new MaterialSkin.Controls.MaterialButton();
            txtLibrary = new MaterialSkin.Controls.MaterialTextBox2();
            btnBrowseLibrary = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            pnlPaths = new Panel();
            btnCheckUpdates = new MaterialSkin.Controls.MaterialButton();
            lblVersionText = new MaterialSkin.Controls.MaterialLabel();
            pnlPaths.SuspendLayout();
            SuspendLayout();
            // 
            // txtGTAFolder
            // 
            txtGTAFolder.AnimateReadOnly = false;
            txtGTAFolder.BackgroundImageLayout = ImageLayout.None;
            txtGTAFolder.CharacterCasing = CharacterCasing.Normal;
            txtGTAFolder.Depth = 0;
            txtGTAFolder.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGTAFolder.HideSelection = true;
            txtGTAFolder.Hint = "GTA V Path";
            txtGTAFolder.LeadingIcon = null;
            txtGTAFolder.Location = new Point(8, 4);
            txtGTAFolder.MaxLength = 32767;
            txtGTAFolder.MouseState = MaterialSkin.MouseState.OUT;
            txtGTAFolder.Name = "txtGTAFolder";
            txtGTAFolder.PasswordChar = '\0';
            txtGTAFolder.PrefixSuffixText = null;
            txtGTAFolder.ReadOnly = true;
            txtGTAFolder.RightToLeft = RightToLeft.No;
            txtGTAFolder.SelectedText = "";
            txtGTAFolder.SelectionLength = 0;
            txtGTAFolder.SelectionStart = 0;
            txtGTAFolder.ShortcutsEnabled = true;
            txtGTAFolder.Size = new Size(464, 48);
            txtGTAFolder.TabIndex = 1;
            txtGTAFolder.TabStop = false;
            txtGTAFolder.TextAlign = HorizontalAlignment.Left;
            txtGTAFolder.TrailingIcon = null;
            txtGTAFolder.UseSystemPasswordChar = false;
            // 
            // btnBrowseGTA
            // 
            btnBrowseGTA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBrowseGTA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBrowseGTA.Depth = 0;
            btnBrowseGTA.HighEmphasis = true;
            btnBrowseGTA.Icon = null;
            btnBrowseGTA.Location = new Point(479, 8);
            btnBrowseGTA.Margin = new Padding(4, 6, 4, 6);
            btnBrowseGTA.MouseState = MaterialSkin.MouseState.HOVER;
            btnBrowseGTA.Name = "btnBrowseGTA";
            btnBrowseGTA.NoAccentTextColor = Color.Empty;
            btnBrowseGTA.Size = new Size(80, 36);
            btnBrowseGTA.TabIndex = 2;
            btnBrowseGTA.Text = "Browse";
            btnBrowseGTA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBrowseGTA.UseAccentColor = false;
            btnBrowseGTA.Click += btnBrowseGTA_Click;
            // 
            // txtLibrary
            // 
            txtLibrary.AnimateReadOnly = false;
            txtLibrary.BackgroundImageLayout = ImageLayout.None;
            txtLibrary.CharacterCasing = CharacterCasing.Normal;
            txtLibrary.Depth = 0;
            txtLibrary.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLibrary.HideSelection = true;
            txtLibrary.Hint = "Library Path";
            txtLibrary.LeadingIcon = null;
            txtLibrary.Location = new Point(8, 60);
            txtLibrary.MaxLength = 32767;
            txtLibrary.MouseState = MaterialSkin.MouseState.OUT;
            txtLibrary.Name = "txtLibrary";
            txtLibrary.PasswordChar = '\0';
            txtLibrary.PrefixSuffixText = null;
            txtLibrary.ReadOnly = true;
            txtLibrary.RightToLeft = RightToLeft.No;
            txtLibrary.SelectedText = "";
            txtLibrary.SelectionLength = 0;
            txtLibrary.SelectionStart = 0;
            txtLibrary.ShortcutsEnabled = true;
            txtLibrary.Size = new Size(464, 48);
            txtLibrary.TabIndex = 4;
            txtLibrary.TabStop = false;
            txtLibrary.TextAlign = HorizontalAlignment.Left;
            txtLibrary.TrailingIcon = null;
            txtLibrary.UseSystemPasswordChar = false;
            // 
            // btnBrowseLibrary
            // 
            btnBrowseLibrary.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBrowseLibrary.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBrowseLibrary.Depth = 0;
            btnBrowseLibrary.HighEmphasis = true;
            btnBrowseLibrary.Icon = null;
            btnBrowseLibrary.Location = new Point(479, 65);
            btnBrowseLibrary.Margin = new Padding(4, 6, 4, 6);
            btnBrowseLibrary.MouseState = MaterialSkin.MouseState.HOVER;
            btnBrowseLibrary.Name = "btnBrowseLibrary";
            btnBrowseLibrary.NoAccentTextColor = Color.Empty;
            btnBrowseLibrary.Size = new Size(80, 36);
            btnBrowseLibrary.TabIndex = 5;
            btnBrowseLibrary.Text = "Browse";
            btnBrowseLibrary.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBrowseLibrary.UseAccentColor = false;
            btnBrowseLibrary.Click += btnBrowseLibrary_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(508, 199);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pnlPaths
            // 
            pnlPaths.BorderStyle = BorderStyle.FixedSingle;
            pnlPaths.Controls.Add(txtGTAFolder);
            pnlPaths.Controls.Add(btnBrowseGTA);
            pnlPaths.Controls.Add(txtLibrary);
            pnlPaths.Controls.Add(btnBrowseLibrary);
            pnlPaths.Location = new Point(12, 70);
            pnlPaths.Name = "pnlPaths";
            pnlPaths.Size = new Size(566, 120);
            pnlPaths.TabIndex = 0;
            // 
            // btnCheckUpdates
            // 
            btnCheckUpdates.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCheckUpdates.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCheckUpdates.Depth = 0;
            btnCheckUpdates.HighEmphasis = true;
            btnCheckUpdates.Icon = null;
            btnCheckUpdates.Location = new Point(12, 199);
            btnCheckUpdates.Margin = new Padding(4, 6, 4, 6);
            btnCheckUpdates.MouseState = MaterialSkin.MouseState.HOVER;
            btnCheckUpdates.Name = "btnCheckUpdates";
            btnCheckUpdates.NoAccentTextColor = Color.Empty;
            btnCheckUpdates.Size = new Size(168, 36);
            btnCheckUpdates.TabIndex = 2;
            btnCheckUpdates.Text = "Check for updates";
            btnCheckUpdates.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCheckUpdates.UseAccentColor = false;
            btnCheckUpdates.Click += btnCheckUpdates_Click;
            // 
            // lblVersionText
            // 
            lblVersionText.Depth = 0;
            lblVersionText.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblVersionText.Location = new Point(187, 208);
            lblVersionText.MouseState = MaterialSkin.MouseState.HOVER;
            lblVersionText.Name = "lblVersionText";
            lblVersionText.Size = new Size(199, 22);
            lblVersionText.TabIndex = 5;
            lblVersionText.Text = "VModManager v[n/a]";
            // 
            // SettingsForm
            // 
            ClientSize = new Size(584, 247);
            Controls.Add(lblVersionText);
            Controls.Add(btnCheckUpdates);
            Controls.Add(pnlPaths);
            Controls.Add(btnSave);
            Name = "SettingsForm";
            Sizable = false;
            Text = "Settings";
            pnlPaths.ResumeLayout(false);
            pnlPaths.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton btnCheckUpdates;
        private MaterialSkin.Controls.MaterialLabel lblVersionText;
    }
}