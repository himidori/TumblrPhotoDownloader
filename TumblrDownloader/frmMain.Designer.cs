namespace TumblrDownloader
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stTheme1 = new STTheme();
            this.statusLBL = new STLabel();
            this.downloadProgress = new STProgressBar();
            this.minimizeBTN = new STButton();
            this.closeBTN = new STButton();
            this.startBTN = new STButton();
            this.stGroupBox1 = new STGroupBox();
            this.browseBTN = new STButton();
            this.stLabel3 = new STLabel();
            this.folderTXT = new STTextBox();
            this.stLabel2 = new STLabel();
            this.tumblrUserTXT = new STTextBox();
            this.stLabel1 = new STLabel();
            this.apiKeyTXT = new STTextBox();
            this.stTheme1.SuspendLayout();
            this.stGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stTheme1
            // 
            this.stTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.stTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.stTheme1.Controls.Add(this.statusLBL);
            this.stTheme1.Controls.Add(this.downloadProgress);
            this.stTheme1.Controls.Add(this.minimizeBTN);
            this.stTheme1.Controls.Add(this.closeBTN);
            this.stTheme1.Controls.Add(this.startBTN);
            this.stTheme1.Controls.Add(this.stGroupBox1);
            this.stTheme1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stTheme1.Name = "stTheme1";
            this.stTheme1.Radius = 5;
            this.stTheme1.Size = new System.Drawing.Size(373, 268);
            this.stTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.stTheme1.Title = "TumblrDownloader";
            this.stTheme1.TitleColorBack = System.Drawing.Color.Black;
            this.stTheme1.TitleColorFront = System.Drawing.Color.White;
            this.stTheme1.TopMost = false;
            this.stTheme1.TransparencyKey = System.Drawing.Color.Magenta;
            // 
            // statusLBL
            // 
            this.statusLBL.Font = new System.Drawing.Font("Verdana", 8F);
            this.statusLBL.Location = new System.Drawing.Point(13, 242);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(42, 14);
            this.statusLBL.Text = "status: ";
            this.statusLBL.TextColor = System.Drawing.Color.White;
            this.statusLBL.TextColorBack = System.Drawing.Color.Black;
            // 
            // downloadProgress
            // 
            this.downloadProgress.BackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.downloadProgress.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.downloadProgress.BorderThickness = 1;
            this.downloadProgress.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold);
            this.downloadProgress.ForeColor = System.Drawing.Color.White;
            this.downloadProgress.Location = new System.Drawing.Point(13, 221);
            this.downloadProgress.Maximum = 100;
            this.downloadProgress.Minimum = 0;
            this.downloadProgress.MinimumSize = new System.Drawing.Size(100, 10);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.downloadProgress.ProgressColor = System.Drawing.Color.SkyBlue;
            this.downloadProgress.ProgressColorBack = System.Drawing.Color.DeepSkyBlue;
            this.downloadProgress.ProgressOutlineColor = System.Drawing.Color.DeepSkyBlue;
            this.downloadProgress.ProgressText = STProgressBar.ProgressTexts.None;
            this.downloadProgress.ProgressTextBackColor = System.Drawing.Color.Black;
            this.downloadProgress.ProgressTextColor = System.Drawing.Color.White;
            this.downloadProgress.Radius = 3;
            this.downloadProgress.Size = new System.Drawing.Size(348, 15);
            this.downloadProgress.Text = "stProgressBar1";
            this.downloadProgress.TextColor = System.Drawing.Color.White;
            this.downloadProgress.TextColorBack = System.Drawing.Color.Empty;
            this.downloadProgress.Value = 0;
            // 
            // minimizeBTN
            // 
            this.minimizeBTN.BackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.minimizeBTN.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.minimizeBTN.DisabledBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.minimizeBTN.DisabledTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimizeBTN.Font = new System.Drawing.Font("Verdana", 8F);
            this.minimizeBTN.HorizontalTextAlign = System.Drawing.StringAlignment.Center;
            this.minimizeBTN.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.minimizeBTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minimizeBTN.Location = new System.Drawing.Point(324, 3);
            this.minimizeBTN.MinimumSize = new System.Drawing.Size(15, 15);
            this.minimizeBTN.Name = "minimizeBTN";
            this.minimizeBTN.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimizeBTN.OutlineThickness = 1;
            this.minimizeBTN.PressedBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minimizeBTN.PressedTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.minimizeBTN.Radius = 3;
            this.minimizeBTN.Size = new System.Drawing.Size(20, 20);
            this.minimizeBTN.TabIndex = 5;
            this.minimizeBTN.Text = "-";
            this.minimizeBTN.TextBackColor = System.Drawing.Color.Black;
            this.minimizeBTN.TextColor = System.Drawing.Color.White;
            this.minimizeBTN.VerticalTextAlign = System.Drawing.StringAlignment.Center;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.BackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closeBTN.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.closeBTN.DisabledBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closeBTN.DisabledTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeBTN.Font = new System.Drawing.Font("Verdana", 8F);
            this.closeBTN.HorizontalTextAlign = System.Drawing.StringAlignment.Center;
            this.closeBTN.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.closeBTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.closeBTN.Location = new System.Drawing.Point(350, 3);
            this.closeBTN.MinimumSize = new System.Drawing.Size(15, 15);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeBTN.OutlineThickness = 1;
            this.closeBTN.PressedBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeBTN.PressedTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.closeBTN.Radius = 3;
            this.closeBTN.Size = new System.Drawing.Size(20, 20);
            this.closeBTN.TabIndex = 3;
            this.closeBTN.Text = "X";
            this.closeBTN.TextBackColor = System.Drawing.Color.Black;
            this.closeBTN.TextColor = System.Drawing.Color.White;
            this.closeBTN.VerticalTextAlign = System.Drawing.StringAlignment.Center;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.BackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.startBTN.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.startBTN.DisabledBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.startBTN.DisabledTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.startBTN.Font = new System.Drawing.Font("Verdana", 8F);
            this.startBTN.HorizontalTextAlign = System.Drawing.StringAlignment.Center;
            this.startBTN.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.startBTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.startBTN.Location = new System.Drawing.Point(221, 182);
            this.startBTN.MinimumSize = new System.Drawing.Size(15, 15);
            this.startBTN.Name = "startBTN";
            this.startBTN.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.startBTN.OutlineThickness = 1;
            this.startBTN.PressedBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.startBTN.PressedTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.startBTN.Radius = 3;
            this.startBTN.Size = new System.Drawing.Size(140, 24);
            this.startBTN.TabIndex = 1;
            this.startBTN.Text = "Start";
            this.startBTN.TextBackColor = System.Drawing.Color.Black;
            this.startBTN.TextColor = System.Drawing.Color.White;
            this.startBTN.VerticalTextAlign = System.Drawing.StringAlignment.Center;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // stGroupBox1
            // 
            this.stGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.stGroupBox1.Controls.Add(this.browseBTN);
            this.stGroupBox1.Controls.Add(this.stLabel3);
            this.stGroupBox1.Controls.Add(this.folderTXT);
            this.stGroupBox1.Controls.Add(this.stLabel2);
            this.stGroupBox1.Controls.Add(this.tumblrUserTXT);
            this.stGroupBox1.Controls.Add(this.stLabel1);
            this.stGroupBox1.Controls.Add(this.apiKeyTXT);
            this.stGroupBox1.Description = "";
            this.stGroupBox1.DescriptionAlign = STGroupBox.DescriptionAligns.Underneath;
            this.stGroupBox1.DescriptionBackColor = System.Drawing.Color.Black;
            this.stGroupBox1.DescriptionColor = System.Drawing.Color.White;
            this.stGroupBox1.DescriptionFont = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic);
            this.stGroupBox1.DrawSeperator = true;
            this.stGroupBox1.Location = new System.Drawing.Point(13, 44);
            this.stGroupBox1.Name = "stGroupBox1";
            this.stGroupBox1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.stGroupBox1.OutlineThickness = 1;
            this.stGroupBox1.Radius = 3;
            this.stGroupBox1.SeperatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.stGroupBox1.SeperatorThickness = 2;
            this.stGroupBox1.Size = new System.Drawing.Size(348, 132);
            this.stGroupBox1.Title = "Settings";
            this.stGroupBox1.TitleBackColor = System.Drawing.Color.Black;
            this.stGroupBox1.TitleColor = System.Drawing.Color.DeepSkyBlue;
            this.stGroupBox1.TitleFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // browseBTN
            // 
            this.browseBTN.BackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.browseBTN.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.browseBTN.DisabledBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.browseBTN.DisabledTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.browseBTN.Font = new System.Drawing.Font("Verdana", 8F);
            this.browseBTN.HorizontalTextAlign = System.Drawing.StringAlignment.Center;
            this.browseBTN.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.browseBTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.browseBTN.Location = new System.Drawing.Point(305, 98);
            this.browseBTN.MinimumSize = new System.Drawing.Size(15, 15);
            this.browseBTN.Name = "browseBTN";
            this.browseBTN.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.browseBTN.OutlineThickness = 1;
            this.browseBTN.PressedBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.browseBTN.PressedTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.browseBTN.Radius = 3;
            this.browseBTN.Size = new System.Drawing.Size(33, 20);
            this.browseBTN.TabIndex = 6;
            this.browseBTN.Text = "...";
            this.browseBTN.TextBackColor = System.Drawing.Color.Black;
            this.browseBTN.TextColor = System.Drawing.Color.White;
            this.browseBTN.VerticalTextAlign = System.Drawing.StringAlignment.Center;
            this.browseBTN.Click += new System.EventHandler(this.browseBTN_Click);
            // 
            // stLabel3
            // 
            this.stLabel3.Font = new System.Drawing.Font("Verdana", 8F);
            this.stLabel3.Location = new System.Drawing.Point(14, 99);
            this.stLabel3.Name = "stLabel3";
            this.stLabel3.Size = new System.Drawing.Size(91, 14);
            this.stLabel3.Text = "DownloadFolder";
            this.stLabel3.TextColor = System.Drawing.Color.White;
            this.stLabel3.TextColorBack = System.Drawing.Color.Black;
            // 
            // folderTXT
            // 
            this.folderTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.folderTXT.BackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.folderTXT.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.folderTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.folderTXT.Enabled = false;
            this.folderTXT.Font = new System.Drawing.Font("Verdana", 8F);
            this.folderTXT.ForeColor = System.Drawing.Color.White;
            this.folderTXT.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.folderTXT.Location = new System.Drawing.Point(111, 98);
            this.folderTXT.Name = "folderTXT";
            this.folderTXT.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.folderTXT.PasswordChar = '\0';
            this.folderTXT.Radius = 3;
            this.folderTXT.Size = new System.Drawing.Size(188, 21);
            this.folderTXT.TabIndex = 3;
            // 
            // stLabel2
            // 
            this.stLabel2.Font = new System.Drawing.Font("Verdana", 8F);
            this.stLabel2.Location = new System.Drawing.Point(14, 63);
            this.stLabel2.Name = "stLabel2";
            this.stLabel2.Size = new System.Drawing.Size(67, 14);
            this.stLabel2.Text = "TumblrUser";
            this.stLabel2.TextColor = System.Drawing.Color.White;
            this.stLabel2.TextColorBack = System.Drawing.Color.Black;
            // 
            // tumblrUserTXT
            // 
            this.tumblrUserTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tumblrUserTXT.BackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tumblrUserTXT.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tumblrUserTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tumblrUserTXT.Font = new System.Drawing.Font("Verdana", 8F);
            this.tumblrUserTXT.ForeColor = System.Drawing.Color.White;
            this.tumblrUserTXT.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tumblrUserTXT.Location = new System.Drawing.Point(111, 63);
            this.tumblrUserTXT.Name = "tumblrUserTXT";
            this.tumblrUserTXT.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tumblrUserTXT.PasswordChar = '\0';
            this.tumblrUserTXT.Radius = 3;
            this.tumblrUserTXT.Size = new System.Drawing.Size(188, 21);
            this.tumblrUserTXT.TabIndex = 1;
            // 
            // stLabel1
            // 
            this.stLabel1.Font = new System.Drawing.Font("Verdana", 8F);
            this.stLabel1.Location = new System.Drawing.Point(14, 28);
            this.stLabel1.Name = "stLabel1";
            this.stLabel1.Size = new System.Drawing.Size(41, 14);
            this.stLabel1.Text = "ApiKey";
            this.stLabel1.TextColor = System.Drawing.Color.White;
            this.stLabel1.TextColorBack = System.Drawing.Color.Black;
            // 
            // apiKeyTXT
            // 
            this.apiKeyTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.apiKeyTXT.BackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.apiKeyTXT.BackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.apiKeyTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apiKeyTXT.Font = new System.Drawing.Font("Verdana", 8F);
            this.apiKeyTXT.ForeColor = System.Drawing.Color.White;
            this.apiKeyTXT.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.apiKeyTXT.Location = new System.Drawing.Point(111, 28);
            this.apiKeyTXT.Name = "apiKeyTXT";
            this.apiKeyTXT.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.apiKeyTXT.PasswordChar = '*';
            this.apiKeyTXT.Radius = 3;
            this.apiKeyTXT.Size = new System.Drawing.Size(188, 21);
            this.apiKeyTXT.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 268);
            this.Controls.Add(this.stTheme1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "TumblrDownloader";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stTheme1.ResumeLayout(false);
            this.stGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private STTheme stTheme1;
        private STGroupBox stGroupBox1;
        private STLabel stLabel1;
        private STTextBox apiKeyTXT;
        private STLabel stLabel2;
        private STTextBox tumblrUserTXT;
        private STLabel stLabel3;
        private STTextBox folderTXT;
        private STButton startBTN;
        private STButton browseBTN;
        private STButton closeBTN;
        private STButton minimizeBTN;
        private STLabel statusLBL;
        private STProgressBar downloadProgress;
    }
}

