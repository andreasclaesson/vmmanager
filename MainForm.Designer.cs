namespace VModManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            presetListBox = new ListBox();
            presetNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            filesListBox = new ListBox();
            btnAddFile = new MaterialSkin.Controls.MaterialButton();
            btnRemoveFile = new MaterialSkin.Controls.MaterialButton();
            btnCreatePreset = new MaterialSkin.Controls.MaterialButton();
            btnDeletePreset = new MaterialSkin.Controls.MaterialButton();
            btnSaveChanges = new MaterialSkin.Controls.MaterialButton();
            btnApplyPreset = new MaterialSkin.Controls.MaterialButton();
            lblActivePreset = new MaterialSkin.Controls.MaterialLabel();
            pnlMain = new Panel();
            lblPresets = new MaterialSkin.Controls.MaterialLabel();
            lblPresetDetails = new MaterialSkin.Controls.MaterialLabel();
            lblFilesInPreset = new MaterialSkin.Controls.MaterialLabel();
            btnExportPreset = new MaterialSkin.Controls.MaterialButton();
            btnImportPreset = new MaterialSkin.Controls.MaterialButton();
            btnSettings = new MaterialSkin.Controls.MaterialButton();
            pnlBottom = new Panel();
            pnlMain.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // presetListBox
            // 
            presetListBox.BackColor = Color.FromArgb(40, 40, 40);
            presetListBox.Font = new Font("Segoe UI", 10F);
            presetListBox.ForeColor = Color.White;
            presetListBox.Location = new Point(8, 30);
            presetListBox.Name = "presetListBox";
            presetListBox.Size = new Size(200, 259);
            presetListBox.TabIndex = 1;
            presetListBox.SelectedIndexChanged += presetListBox_SelectedIndexChanged;
            // 
            // presetNameTextBox
            // 
            presetNameTextBox.AnimateReadOnly = false;
            presetNameTextBox.BackgroundImageLayout = ImageLayout.None;
            presetNameTextBox.CharacterCasing = CharacterCasing.Normal;
            presetNameTextBox.Depth = 0;
            presetNameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            presetNameTextBox.HideSelection = true;
            presetNameTextBox.Hint = "Preset name";
            presetNameTextBox.LeadingIcon = null;
            presetNameTextBox.Location = new Point(220, 30);
            presetNameTextBox.MaxLength = 32767;
            presetNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            presetNameTextBox.Name = "presetNameTextBox";
            presetNameTextBox.PasswordChar = '\0';
            presetNameTextBox.PrefixSuffixText = null;
            presetNameTextBox.ReadOnly = true;
            presetNameTextBox.RightToLeft = RightToLeft.No;
            presetNameTextBox.SelectedText = "";
            presetNameTextBox.SelectionLength = 0;
            presetNameTextBox.SelectionStart = 0;
            presetNameTextBox.ShortcutsEnabled = true;
            presetNameTextBox.Size = new Size(460, 48);
            presetNameTextBox.TabIndex = 4;
            presetNameTextBox.TabStop = false;
            presetNameTextBox.TextAlign = HorizontalAlignment.Left;
            presetNameTextBox.TrailingIcon = null;
            presetNameTextBox.UseSystemPasswordChar = false;
            // 
            // filesListBox
            // 
            filesListBox.BackColor = Color.FromArgb(40, 40, 40);
            filesListBox.Font = new Font("Consolas", 9.5F);
            filesListBox.ForeColor = Color.White;
            filesListBox.Location = new Point(220, 107);
            filesListBox.Name = "filesListBox";
            filesListBox.Size = new Size(460, 139);
            filesListBox.TabIndex = 6;
            // 
            // btnAddFile
            // 
            btnAddFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddFile.Depth = 0;
            btnAddFile.HighEmphasis = true;
            btnAddFile.Icon = null;
            btnAddFile.Location = new Point(220, 253);
            btnAddFile.Margin = new Padding(4, 6, 4, 6);
            btnAddFile.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddFile.Name = "btnAddFile";
            btnAddFile.NoAccentTextColor = Color.Empty;
            btnAddFile.Size = new Size(83, 36);
            btnAddFile.TabIndex = 7;
            btnAddFile.Text = "Add File";
            btnAddFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddFile.UseAccentColor = false;
            btnAddFile.Click += btnAddFile_Click;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemoveFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemoveFile.Depth = 0;
            btnRemoveFile.HighEmphasis = true;
            btnRemoveFile.Icon = null;
            btnRemoveFile.Location = new Point(311, 253);
            btnRemoveFile.Margin = new Padding(4, 6, 4, 6);
            btnRemoveFile.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.NoAccentTextColor = Color.Empty;
            btnRemoveFile.Size = new Size(112, 36);
            btnRemoveFile.TabIndex = 8;
            btnRemoveFile.Text = "Remove File";
            btnRemoveFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemoveFile.UseAccentColor = false;
            btnRemoveFile.Click += btnRemoveFile_Click;
            // 
            // btnCreatePreset
            // 
            btnCreatePreset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreatePreset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreatePreset.Depth = 0;
            btnCreatePreset.HighEmphasis = true;
            btnCreatePreset.Icon = null;
            btnCreatePreset.Location = new Point(6, 6);
            btnCreatePreset.Margin = new Padding(4, 6, 4, 6);
            btnCreatePreset.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreatePreset.Name = "btnCreatePreset";
            btnCreatePreset.NoAccentTextColor = Color.Empty;
            btnCreatePreset.Size = new Size(132, 36);
            btnCreatePreset.TabIndex = 0;
            btnCreatePreset.Text = "Create Preset";
            btnCreatePreset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreatePreset.UseAccentColor = false;
            btnCreatePreset.Click += btnCreatePreset_Click;
            // 
            // btnDeletePreset
            // 
            btnDeletePreset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeletePreset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeletePreset.Depth = 0;
            btnDeletePreset.HighEmphasis = true;
            btnDeletePreset.Icon = null;
            btnDeletePreset.Location = new Point(146, 6);
            btnDeletePreset.Margin = new Padding(4, 6, 4, 6);
            btnDeletePreset.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeletePreset.Name = "btnDeletePreset";
            btnDeletePreset.NoAccentTextColor = Color.Empty;
            btnDeletePreset.Size = new Size(130, 36);
            btnDeletePreset.TabIndex = 1;
            btnDeletePreset.Text = "Delete Preset";
            btnDeletePreset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeletePreset.UseAccentColor = false;
            btnDeletePreset.Click += btnDeletePreset_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveChanges.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveChanges.Depth = 0;
            btnSaveChanges.HighEmphasis = true;
            btnSaveChanges.Icon = null;
            btnSaveChanges.Location = new Point(561, 6);
            btnSaveChanges.Margin = new Padding(4, 6, 4, 6);
            btnSaveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.NoAccentTextColor = Color.Empty;
            btnSaveChanges.Size = new Size(129, 36);
            btnSaveChanges.TabIndex = 2;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveChanges.UseAccentColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnApplyPreset
            // 
            btnApplyPreset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApplyPreset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplyPreset.Depth = 0;
            btnApplyPreset.HighEmphasis = true;
            btnApplyPreset.Icon = null;
            btnApplyPreset.Location = new Point(19, 439);
            btnApplyPreset.Margin = new Padding(4, 6, 4, 6);
            btnApplyPreset.MouseState = MaterialSkin.MouseState.HOVER;
            btnApplyPreset.Name = "btnApplyPreset";
            btnApplyPreset.NoAccentTextColor = Color.Empty;
            btnApplyPreset.Size = new Size(123, 36);
            btnApplyPreset.TabIndex = 3;
            btnApplyPreset.Text = "Apply Preset";
            btnApplyPreset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnApplyPreset.UseAccentColor = false;
            btnApplyPreset.Click += btnApplyPreset_Click;
            // 
            // lblActivePreset
            // 
            lblActivePreset.Depth = 0;
            lblActivePreset.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblActivePreset.Location = new Point(149, 449);
            lblActivePreset.MouseState = MaterialSkin.MouseState.HOVER;
            lblActivePreset.Name = "lblActivePreset";
            lblActivePreset.Size = new Size(300, 22);
            lblActivePreset.TabIndex = 4;
            lblActivePreset.Text = "Active: n/a";
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(lblPresets);
            pnlMain.Controls.Add(presetListBox);
            pnlMain.Controls.Add(lblPresetDetails);
            pnlMain.Controls.Add(presetNameTextBox);
            pnlMain.Controls.Add(lblFilesInPreset);
            pnlMain.Controls.Add(filesListBox);
            pnlMain.Controls.Add(btnAddFile);
            pnlMain.Controls.Add(btnRemoveFile);
            pnlMain.Location = new Point(12, 76);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(696, 300);
            pnlMain.TabIndex = 1;
            // 
            // lblPresets
            // 
            lblPresets.Depth = 0;
            lblPresets.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPresets.Location = new Point(8, 6);
            lblPresets.MouseState = MaterialSkin.MouseState.HOVER;
            lblPresets.Name = "lblPresets";
            lblPresets.Size = new Size(180, 22);
            lblPresets.TabIndex = 0;
            lblPresets.Text = "Presets";
            // 
            // lblPresetDetails
            // 
            lblPresetDetails.Depth = 0;
            lblPresetDetails.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPresetDetails.Location = new Point(220, 5);
            lblPresetDetails.MouseState = MaterialSkin.MouseState.HOVER;
            lblPresetDetails.Name = "lblPresetDetails";
            lblPresetDetails.Size = new Size(460, 22);
            lblPresetDetails.TabIndex = 2;
            lblPresetDetails.Text = "Preset Details";
            // 
            // lblFilesInPreset
            // 
            lblFilesInPreset.Depth = 0;
            lblFilesInPreset.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFilesInPreset.Location = new Point(220, 82);
            lblFilesInPreset.MouseState = MaterialSkin.MouseState.HOVER;
            lblFilesInPreset.Name = "lblFilesInPreset";
            lblFilesInPreset.Size = new Size(150, 22);
            lblFilesInPreset.TabIndex = 5;
            lblFilesInPreset.Text = "Files in Preset:";
            // 
            // btnExportPreset
            // 
            btnExportPreset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExportPreset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExportPreset.Depth = 0;
            btnExportPreset.HighEmphasis = false;
            btnExportPreset.Icon = null;
            btnExportPreset.Location = new Point(636, 26);
            btnExportPreset.Margin = new Padding(4, 6, 4, 6);
            btnExportPreset.MouseState = MaterialSkin.MouseState.HOVER;
            btnExportPreset.Name = "btnExportPreset";
            btnExportPreset.NoAccentTextColor = Color.Empty;
            btnExportPreset.Size = new Size(77, 36);
            btnExportPreset.TabIndex = 9;
            btnExportPreset.Text = "Export";
            btnExportPreset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExportPreset.UseAccentColor = false;
            btnExportPreset.Click += btnExportPreset_Click;
            // 
            // btnImportPreset
            // 
            btnImportPreset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImportPreset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImportPreset.Depth = 0;
            btnImportPreset.HighEmphasis = false;
            btnImportPreset.Icon = null;
            btnImportPreset.Location = new Point(552, 26);
            btnImportPreset.Margin = new Padding(4, 6, 4, 6);
            btnImportPreset.MouseState = MaterialSkin.MouseState.HOVER;
            btnImportPreset.Name = "btnImportPreset";
            btnImportPreset.NoAccentTextColor = Color.Empty;
            btnImportPreset.Size = new Size(76, 36);
            btnImportPreset.TabIndex = 10;
            btnImportPreset.Text = "Import";
            btnImportPreset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImportPreset.UseAccentColor = false;
            btnImportPreset.Click += btnImportPreset_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSettings.Depth = 0;
            btnSettings.HighEmphasis = true;
            btnSettings.Icon = null;
            btnSettings.Location = new Point(613, 439);
            btnSettings.Margin = new Padding(4, 6, 4, 6);
            btnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            btnSettings.Name = "btnSettings";
            btnSettings.NoAccentTextColor = Color.Empty;
            btnSettings.Size = new Size(90, 36);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSettings.UseAccentColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.BorderStyle = BorderStyle.FixedSingle;
            pnlBottom.Controls.Add(btnCreatePreset);
            pnlBottom.Controls.Add(btnDeletePreset);
            pnlBottom.Controls.Add(btnSaveChanges);
            pnlBottom.Location = new Point(12, 377);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(696, 53);
            pnlBottom.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 491);
            Controls.Add(pnlMain);
            Controls.Add(pnlBottom);
            Controls.Add(btnApplyPreset);
            Controls.Add(lblActivePreset);
            Controls.Add(btnSettings);
            Controls.Add(btnExportPreset);
            Controls.Add(btnImportPreset);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Sizable = false;
            Text = "V Mod Manager";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListBox presetListBox;
        private MaterialSkin.Controls.MaterialButton btnExportPreset;
        private MaterialSkin.Controls.MaterialButton btnImportPreset;
        private MaterialSkin.Controls.MaterialTextBox2 presetNameTextBox;
        private System.Windows.Forms.ListBox filesListBox;
        private MaterialSkin.Controls.MaterialButton btnAddFile;
        private MaterialSkin.Controls.MaterialButton btnRemoveFile;
        private MaterialSkin.Controls.MaterialButton btnCreatePreset;
        private MaterialSkin.Controls.MaterialButton btnDeletePreset;
        private MaterialSkin.Controls.MaterialButton btnSaveChanges;
        private MaterialSkin.Controls.MaterialButton btnApplyPreset;
        private MaterialSkin.Controls.MaterialButton btnSettings;
        private MaterialSkin.Controls.MaterialLabel lblActivePreset;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private MaterialSkin.Controls.MaterialLabel lblPresets;
        private MaterialSkin.Controls.MaterialLabel lblPresetDetails;
        private MaterialSkin.Controls.MaterialLabel lblFilesInPreset;
    }
}
