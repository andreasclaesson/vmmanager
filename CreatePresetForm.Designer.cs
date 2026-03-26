namespace VModManager
{
    partial class CreatePresetForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtPresetName = new MaterialSkin.Controls.MaterialTextBox2();
            chkFiles = new CheckedListBox();
            btnOk = new MaterialSkin.Controls.MaterialButton();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            lblPresetName = new MaterialSkin.Controls.MaterialLabel();
            lblAvailableFiles = new MaterialSkin.Controls.MaterialLabel();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtPresetName
            // 
            txtPresetName.AnimateReadOnly = false;
            txtPresetName.BackgroundImageLayout = ImageLayout.None;
            txtPresetName.CharacterCasing = CharacterCasing.Normal;
            txtPresetName.Depth = 0;
            txtPresetName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPresetName.HideSelection = true;
            txtPresetName.Hint = "Enter preset name";
            txtPresetName.LeadingIcon = null;
            txtPresetName.Location = new Point(10, 35);
            txtPresetName.MaxLength = 32767;
            txtPresetName.MouseState = MaterialSkin.MouseState.OUT;
            txtPresetName.Name = "txtPresetName";
            txtPresetName.PasswordChar = '\0';
            txtPresetName.PrefixSuffixText = null;
            txtPresetName.ReadOnly = false;
            txtPresetName.RightToLeft = RightToLeft.No;
            txtPresetName.SelectedText = "";
            txtPresetName.SelectionLength = 0;
            txtPresetName.SelectionStart = 0;
            txtPresetName.ShortcutsEnabled = true;
            txtPresetName.Size = new Size(330, 48);
            txtPresetName.TabIndex = 1;
            txtPresetName.TabStop = false;
            txtPresetName.TextAlign = HorizontalAlignment.Left;
            txtPresetName.TrailingIcon = null;
            txtPresetName.UseSystemPasswordChar = false;
            // 
            // chkFiles
            // 
            chkFiles.BackColor = Color.FromArgb(40, 40, 40);
            chkFiles.BorderStyle = BorderStyle.None;
            chkFiles.CheckOnClick = true;
            chkFiles.ForeColor = Color.White;
            chkFiles.Location = new Point(10, 115);
            chkFiles.Name = "chkFiles";
            chkFiles.Size = new Size(330, 72);
            chkFiles.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOk.Depth = 0;
            btnOk.HighEmphasis = true;
            btnOk.Icon = null;
            btnOk.Location = new Point(10, 196);
            btnOk.Margin = new Padding(4, 6, 4, 6);
            btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            btnOk.Name = "btnOk";
            btnOk.NoAccentTextColor = Color.Empty;
            btnOk.Size = new Size(64, 36);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOk.UseAccentColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(263, 196);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPresetName
            // 
            lblPresetName.Depth = 0;
            lblPresetName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPresetName.Location = new Point(10, 10);
            lblPresetName.MouseState = MaterialSkin.MouseState.HOVER;
            lblPresetName.Name = "lblPresetName";
            lblPresetName.Size = new Size(100, 22);
            lblPresetName.TabIndex = 0;
            lblPresetName.Text = "Preset Name:";
            // 
            // lblAvailableFiles
            // 
            lblAvailableFiles.Depth = 0;
            lblAvailableFiles.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAvailableFiles.Location = new Point(10, 90);
            lblAvailableFiles.MouseState = MaterialSkin.MouseState.HOVER;
            lblAvailableFiles.Name = "lblAvailableFiles";
            lblAvailableFiles.Size = new Size(150, 22);
            lblAvailableFiles.TabIndex = 2;
            lblAvailableFiles.Text = "Available DLL/ASI Files:";
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(lblPresetName);
            pnlMain.Controls.Add(txtPresetName);
            pnlMain.Controls.Add(lblAvailableFiles);
            pnlMain.Controls.Add(chkFiles);
            pnlMain.Controls.Add(btnOk);
            pnlMain.Controls.Add(btnCancel);
            pnlMain.Location = new Point(6, 69);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(354, 250);
            pnlMain.TabIndex = 0;
            // 
            // CreatePresetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 325);
            Controls.Add(pnlMain);
            Name = "CreatePresetForm";
            Sizable = false;
            Text = "Create Preset";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtPresetName;
        private CheckedListBox chkFiles;
        private MaterialSkin.Controls.MaterialButton btnOk;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblPresetName;
        private MaterialSkin.Controls.MaterialLabel lblAvailableFiles;
        private Panel pnlMain;
    }
}