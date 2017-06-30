namespace VideoWriter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateVideoButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalFramesLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusText2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gifTextbox = new System.Windows.Forms.TextBox();
            this.mp3Textbox = new System.Windows.Forms.TextBox();
            this.GIFButton = new System.Windows.Forms.Button();
            this.MP3Button = new System.Windows.Forms.Button();
            this.MP3Label = new System.Windows.Forms.Label();
            this.GifLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gifSoundVideoConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ChangeOutputFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderOutputPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.videoDuration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateVideoButton
            // 
            this.CreateVideoButton.Location = new System.Drawing.Point(34, 144);
            this.CreateVideoButton.Name = "CreateVideoButton";
            this.CreateVideoButton.Size = new System.Drawing.Size(294, 43);
            this.CreateVideoButton.TabIndex = 0;
            this.CreateVideoButton.Text = "Create Video";
            this.CreateVideoButton.UseVisualStyleBackColor = true;
            this.CreateVideoButton.Click += new System.EventHandler(this.buttonCreateVideo_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 225);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(642, 32);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "frames out of";
            // 
            // totalFramesLabel
            // 
            this.totalFramesLabel.AutoSize = true;
            this.totalFramesLabel.Location = new System.Drawing.Point(387, 260);
            this.totalFramesLabel.Name = "totalFramesLabel";
            this.totalFramesLabel.Size = new System.Drawing.Size(35, 13);
            this.totalFramesLabel.TabIndex = 5;
            this.totalFramesLabel.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 283);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(642, 156);
            this.textBox1.TabIndex = 6;
            // 
            // statusText2
            // 
            this.statusText2.AutoSize = true;
            this.statusText2.Location = new System.Drawing.Point(34, 209);
            this.statusText2.Name = "statusText2";
            this.statusText2.Size = new System.Drawing.Size(37, 13);
            this.statusText2.TabIndex = 8;
            this.statusText2.Text = "Status";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(544, 164);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(132, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gifTextbox
            // 
            this.gifTextbox.Location = new System.Drawing.Point(34, 111);
            this.gifTextbox.Name = "gifTextbox";
            this.gifTextbox.ReadOnly = true;
            this.gifTextbox.Size = new System.Drawing.Size(294, 20);
            this.gifTextbox.TabIndex = 11;
            // 
            // mp3Textbox
            // 
            this.mp3Textbox.Location = new System.Drawing.Point(382, 111);
            this.mp3Textbox.Name = "mp3Textbox";
            this.mp3Textbox.ReadOnly = true;
            this.mp3Textbox.Size = new System.Drawing.Size(294, 20);
            this.mp3Textbox.TabIndex = 12;
            // 
            // GIFButton
            // 
            this.GIFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIFButton.Location = new System.Drawing.Point(126, 36);
            this.GIFButton.Name = "GIFButton";
            this.GIFButton.Size = new System.Drawing.Size(99, 55);
            this.GIFButton.TabIndex = 13;
            this.GIFButton.Text = "Select GIF";
            this.GIFButton.UseVisualStyleBackColor = true;
            this.GIFButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MP3Button
            // 
            this.MP3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP3Button.Location = new System.Drawing.Point(472, 36);
            this.MP3Button.Name = "MP3Button";
            this.MP3Button.Size = new System.Drawing.Size(99, 55);
            this.MP3Button.TabIndex = 14;
            this.MP3Button.Text = "Select MP3";
            this.MP3Button.UseVisualStyleBackColor = true;
            this.MP3Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // MP3Label
            // 
            this.MP3Label.AutoSize = true;
            this.MP3Label.Location = new System.Drawing.Point(385, 97);
            this.MP3Label.Name = "MP3Label";
            this.MP3Label.Size = new System.Drawing.Size(55, 13);
            this.MP3Label.TabIndex = 15;
            this.MP3Label.Text = "MP3Label";
            this.MP3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GifLabel
            // 
            this.GifLabel.AutoSize = true;
            this.GifLabel.Location = new System.Drawing.Point(37, 96);
            this.GifLabel.Name = "GifLabel";
            this.GifLabel.Size = new System.Drawing.Size(46, 13);
            this.GifLabel.TabIndex = 16;
            this.GifLabel.Text = "GifLabel";
            this.GifLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gifSoundVideoConverterToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // gifSoundVideoConverterToolStripMenuItem
            // 
            this.gifSoundVideoConverterToolStripMenuItem.Name = "gifSoundVideoConverterToolStripMenuItem";
            this.gifSoundVideoConverterToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.gifSoundVideoConverterToolStripMenuItem.Text = "GifSound VideoConverter";
            this.gifSoundVideoConverterToolStripMenuItem.Click += new System.EventHandler(this.gifSoundVideoConverterToolStripMenuItem_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(712, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(118, 17);
            this.statusText.Text = "toolStripStatusLabel2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "No audio";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChangeOutputFolder
            // 
            this.ChangeOutputFolder.Location = new System.Drawing.Point(544, 445);
            this.ChangeOutputFolder.Name = "ChangeOutputFolder";
            this.ChangeOutputFolder.Size = new System.Drawing.Size(132, 23);
            this.ChangeOutputFolder.TabIndex = 20;
            this.ChangeOutputFolder.Text = "Change output folder";
            this.ChangeOutputFolder.UseVisualStyleBackColor = true;
            this.ChangeOutputFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // FolderOutputPath
            // 
            this.FolderOutputPath.Location = new System.Drawing.Point(191, 448);
            this.FolderOutputPath.Name = "FolderOutputPath";
            this.FolderOutputPath.ReadOnly = true;
            this.FolderOutputPath.Size = new System.Drawing.Size(347, 20);
            this.FolderOutputPath.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.videoDuration);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(382, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 70);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // videoDuration
            // 
            this.videoDuration.Enabled = false;
            this.videoDuration.Location = new System.Drawing.Point(8, 38);
            this.videoDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.videoDuration.Name = "videoDuration";
            this.videoDuration.Size = new System.Drawing.Size(51, 20);
            this.videoDuration.TabIndex = 20;
            this.videoDuration.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.videoDuration.ValueChanged += new System.EventHandler(this.videoDuration_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Video duration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FolderOutputPath);
            this.Controls.Add(this.ChangeOutputFolder);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GifLabel);
            this.Controls.Add(this.MP3Label);
            this.Controls.Add(this.MP3Button);
            this.Controls.Add(this.GIFButton);
            this.Controls.Add(this.mp3Textbox);
            this.Controls.Add(this.gifTextbox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.statusText2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.totalFramesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CreateVideoButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VideoWriter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gifSoundVideoConverterToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Button CreateVideoButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label totalFramesLabel;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label statusText2;
        public System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox gifTextbox;
        public System.Windows.Forms.TextBox mp3Textbox;
        public System.Windows.Forms.Button GIFButton;
        public System.Windows.Forms.Button MP3Button;
        public System.Windows.Forms.Label MP3Label;
        public System.Windows.Forms.Label GifLabel;
        public System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ChangeOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox FolderOutputPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown videoDuration;
    }
}

