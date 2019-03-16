namespace USBTool
{
    partial class AppForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.MiniAppButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FileSystemSelection = new System.Windows.Forms.ComboBox();
            this.DriveList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.UseSpeedFormatage = new System.Windows.Forms.CheckBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.WriteIsoFile = new System.Windows.Forms.CheckBox();
            this.BrowseForIso = new System.Windows.Forms.Button();
            this.AppNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.MiniAppButton);
            this.TopPanel.Controls.Add(this.CloseAppButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(294, 30);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.CloseAppButton.Location = new System.Drawing.Point(265, 1);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(26, 26);
            this.CloseAppButton.TabIndex = 0;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // MiniAppButton
            // 
            this.MiniAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.MiniAppButton.Location = new System.Drawing.Point(236, 1);
            this.MiniAppButton.Name = "MiniAppButton";
            this.MiniAppButton.Size = new System.Drawing.Size(26, 26);
            this.MiniAppButton.TabIndex = 1;
            this.MiniAppButton.UseVisualStyleBackColor = true;
            this.MiniAppButton.Click += new System.EventHandler(this.MiniAppButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drive Tools 1.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Système de fichier";
            // 
            // FileSystemSelection
            // 
            this.FileSystemSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.FileSystemSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileSystemSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileSystemSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.FileSystemSelection.FormattingEnabled = true;
            this.FileSystemSelection.Items.AddRange(new object[] {
            "NTFS",
            "FAT",
            "FAT32",
            "exFAT"});
            this.FileSystemSelection.Location = new System.Drawing.Point(12, 110);
            this.FileSystemSelection.Name = "FileSystemSelection";
            this.FileSystemSelection.Size = new System.Drawing.Size(268, 21);
            this.FileSystemSelection.TabIndex = 4;
            // 
            // DriveList
            // 
            this.DriveList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.DriveList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriveList.ForeColor = System.Drawing.SystemColors.Control;
            this.DriveList.FormattingEnabled = true;
            this.DriveList.Items.AddRange(new object[] {
            "..."});
            this.DriveList.Location = new System.Drawing.Point(12, 58);
            this.DriveList.Name = "DriveList";
            this.DriveList.Size = new System.Drawing.Size(268, 21);
            this.DriveList.TabIndex = 5;
            this.DriveList.SelectedIndexChanged += new System.EventHandler(this.DriveList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom du volume";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(12, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 7;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.OptionsGroupBox.Controls.Add(this.label5);
            this.OptionsGroupBox.Controls.Add(this.BrowseForIso);
            this.OptionsGroupBox.Controls.Add(this.WriteIsoFile);
            this.OptionsGroupBox.Controls.Add(this.UseSpeedFormatage);
            this.OptionsGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.OptionsGroupBox.Location = new System.Drawing.Point(12, 198);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(268, 68);
            this.OptionsGroupBox.TabIndex = 8;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // UseSpeedFormatage
            // 
            this.UseSpeedFormatage.AutoSize = true;
            this.UseSpeedFormatage.Location = new System.Drawing.Point(8, 19);
            this.UseSpeedFormatage.Name = "UseSpeedFormatage";
            this.UseSpeedFormatage.Size = new System.Drawing.Size(108, 17);
            this.UseSpeedFormatage.TabIndex = 0;
            this.UseSpeedFormatage.Text = "Formatage rapide";
            this.UseSpeedFormatage.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ButtonStart.Location = new System.Drawing.Point(205, 304);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 9;
            this.ButtonStart.Text = "Démarrer";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // WriteIsoFile
            // 
            this.WriteIsoFile.AutoSize = true;
            this.WriteIsoFile.Location = new System.Drawing.Point(8, 42);
            this.WriteIsoFile.Name = "WriteIsoFile";
            this.WriteIsoFile.Size = new System.Drawing.Size(94, 17);
            this.WriteIsoFile.TabIndex = 1;
            this.WriteIsoFile.Text = "Graver un ISO";
            this.WriteIsoFile.UseVisualStyleBackColor = true;
            // 
            // BrowseForIso
            // 
            this.BrowseForIso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseForIso.Location = new System.Drawing.Point(102, 39);
            this.BrowseForIso.Name = "BrowseForIso";
            this.BrowseForIso.Size = new System.Drawing.Size(31, 21);
            this.BrowseForIso.TabIndex = 2;
            this.BrowseForIso.Text = "...";
            this.BrowseForIso.UseVisualStyleBackColor = true;
            this.BrowseForIso.Click += new System.EventHandler(this.BrowseForIso_Click);
            // 
            // AppNotify
            // 
            this.AppNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.AppNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("AppNotify.Icon")));
            this.AppNotify.Text = "Drive Tools";
            this.AppNotify.Visible = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(294, 336);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DriveList);
            this.Controls.Add(this.FileSystemSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drive Tools";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button CloseAppButton;
        private System.Windows.Forms.Button MiniAppButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FileSystemSelection;
        private System.Windows.Forms.ComboBox DriveList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.CheckBox UseSpeedFormatage;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button BrowseForIso;
        private System.Windows.Forms.CheckBox WriteIsoFile;
        private System.Windows.Forms.NotifyIcon AppNotify;
        private System.Windows.Forms.Label label5;
    }
}

