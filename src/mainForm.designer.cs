using System.Drawing;
namespace YouTube_Downloader
{
    partial class mainForm
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
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
               this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
               this.get_Button = new System.Windows.Forms.Button();
               this.url_TextBox = new System.Windows.Forms.TextBox();
               this.url_Label = new System.Windows.Forms.Label();
               this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
               this.paste_Button = new System.Windows.Forms.Button();
               this.progressBar1 = new System.Windows.Forms.ProgressBar();
               this.panel1 = new System.Windows.Forms.Panel();
               this.button1 = new System.Windows.Forms.Button();
               this.exit_Button = new System.Windows.Forms.Button();
               this.timer1 = new System.Windows.Forms.Timer(this.components);
               this.grop_Panel1 = new System.Windows.Forms.Panel();
               this.grop_Panel2 = new System.Windows.Forms.Panel();
               this.name_Label2 = new System.Windows.Forms.Label();
               this.copy_Button = new System.Windows.Forms.Button();
               this.quality_ComboBox = new System.Windows.Forms.ComboBox();
               this.quality_Label = new System.Windows.Forms.Label();
               this.name_Label1 = new System.Windows.Forms.Label();
               this.video_PictureBox = new System.Windows.Forms.PictureBox();
               this.down_Button = new System.Windows.Forms.Button();
               this.panel2 = new System.Windows.Forms.Panel();
               this.logo_PictureBox = new System.Windows.Forms.PictureBox();
               this.panel1.SuspendLayout();
               this.grop_Panel1.SuspendLayout();
               this.grop_Panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.video_PictureBox)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.logo_PictureBox)).BeginInit();
               this.SuspendLayout();
               // 
               // backgroundWorker1
               // 
               this.backgroundWorker1.WorkerReportsProgress = true;
               this.backgroundWorker1.WorkerSupportsCancellation = true;
               this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
               this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
               // 
               // get_Button
               // 
               this.get_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.get_Button.BackColor = System.Drawing.Color.White;
               this.get_Button.Enabled = false;
               this.get_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
               this.get_Button.Location = new System.Drawing.Point(228, 58);
               this.get_Button.Name = "get_Button";
               this.get_Button.Size = new System.Drawing.Size(90, 23);
               this.get_Button.TabIndex = 3;
               this.get_Button.Text = "Get Video";
               this.get_Button.UseVisualStyleBackColor = false;
               this.get_Button.Click += new System.EventHandler(this.get_Button_Click);
               // 
               // url_TextBox
               // 
               this.url_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.url_TextBox.Location = new System.Drawing.Point(9, 32);
               this.url_TextBox.Name = "url_TextBox";
               this.url_TextBox.Size = new System.Drawing.Size(309, 20);
               this.url_TextBox.TabIndex = 1;
               this.url_TextBox.TextChanged += new System.EventHandler(this.url_TextBox_TextChanged);
               this.url_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUrl_KeyPress);
               // 
               // url_Label
               // 
               this.url_Label.AutoSize = true;
               this.url_Label.Font = new System.Drawing.Font("Tahoma", 12F);
               this.url_Label.Location = new System.Drawing.Point(9, 10);
               this.url_Label.Name = "url_Label";
               this.url_Label.Size = new System.Drawing.Size(113, 19);
               this.url_Label.TabIndex = 0;
               this.url_Label.Text = "YouTube URL:";
               this.url_Label.Click += new System.EventHandler(this.url_Label_Click);
               // 
               // saveFileDialog1
               // 
               this.saveFileDialog1.Title = "Save the download file";
               // 
               // paste_Button
               // 
               this.paste_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.paste_Button.BackColor = System.Drawing.Color.White;
               this.paste_Button.Enabled = false;
               this.paste_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
               this.paste_Button.Location = new System.Drawing.Point(152, 58);
               this.paste_Button.Name = "paste_Button";
               this.paste_Button.Size = new System.Drawing.Size(70, 23);
               this.paste_Button.TabIndex = 2;
               this.paste_Button.Text = "Paste";
               this.paste_Button.UseVisualStyleBackColor = false;
               this.paste_Button.Click += new System.EventHandler(this.paste_Button_Click);
               // 
               // progressBar1
               // 
               this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.progressBar1.Location = new System.Drawing.Point(12, 19);
               this.progressBar1.MarqueeAnimationSpeed = 50;
               this.progressBar1.Name = "progressBar1";
               this.progressBar1.Size = new System.Drawing.Size(189, 12);
               this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
               this.progressBar1.TabIndex = 0;
               this.progressBar1.Visible = false;
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.Black;
               this.panel1.Controls.Add(this.button1);
               this.panel1.Controls.Add(this.exit_Button);
               this.panel1.Controls.Add(this.progressBar1);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.panel1.Location = new System.Drawing.Point(0, 239);
               this.panel1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(447, 48);
               this.panel1.TabIndex = 2;
               this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
               // 
               // button1
               // 
               this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.button1.BackColor = System.Drawing.Color.White;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
               this.button1.Location = new System.Drawing.Point(269, 13);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(80, 23);
               this.button1.TabIndex = 1;
               this.button1.Text = "About";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // exit_Button
               // 
               this.exit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.exit_Button.BackColor = System.Drawing.Color.White;
               this.exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
               this.exit_Button.Location = new System.Drawing.Point(355, 13);
               this.exit_Button.Name = "exit_Button";
               this.exit_Button.Size = new System.Drawing.Size(80, 23);
               this.exit_Button.TabIndex = 2;
               this.exit_Button.Text = "Exit";
               this.exit_Button.UseVisualStyleBackColor = false;
               this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
               // 
               // timer1
               // 
               this.timer1.Enabled = true;
               this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
               // 
               // grop_Panel1
               // 
               this.grop_Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.grop_Panel1.BackColor = System.Drawing.Color.Black;
               this.grop_Panel1.Controls.Add(this.paste_Button);
               this.grop_Panel1.Controls.Add(this.url_Label);
               this.grop_Panel1.Controls.Add(this.get_Button);
               this.grop_Panel1.Controls.Add(this.url_TextBox);
               this.grop_Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.grop_Panel1.Location = new System.Drawing.Point(108, 15);
               this.grop_Panel1.Name = "grop_Panel1";
               this.grop_Panel1.Padding = new System.Windows.Forms.Padding(6);
               this.grop_Panel1.Size = new System.Drawing.Size(327, 90);
               this.grop_Panel1.TabIndex = 0;
               this.grop_Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.grop_Panel1_Paint);
               this.grop_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
               // 
               // grop_Panel2
               // 
               this.grop_Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.grop_Panel2.BackColor = System.Drawing.Color.Black;
               this.grop_Panel2.Controls.Add(this.name_Label2);
               this.grop_Panel2.Controls.Add(this.copy_Button);
               this.grop_Panel2.Controls.Add(this.quality_ComboBox);
               this.grop_Panel2.Controls.Add(this.quality_Label);
               this.grop_Panel2.Controls.Add(this.name_Label1);
               this.grop_Panel2.Controls.Add(this.video_PictureBox);
               this.grop_Panel2.Controls.Add(this.down_Button);
               this.grop_Panel2.Location = new System.Drawing.Point(12, 117);
               this.grop_Panel2.Name = "grop_Panel2";
               this.grop_Panel2.Padding = new System.Windows.Forms.Padding(6);
               this.grop_Panel2.Size = new System.Drawing.Size(423, 110);
               this.grop_Panel2.TabIndex = 1;
               this.grop_Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.grop_Panel2_Paint);
               // 
               // name_Label2
               // 
               this.name_Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.name_Label2.BackColor = System.Drawing.Color.White;
               this.name_Label2.Location = new System.Drawing.Point(191, 21);
               this.name_Label2.Name = "name_Label2";
               this.name_Label2.Size = new System.Drawing.Size(223, 19);
               this.name_Label2.TabIndex = 1;
               this.name_Label2.Text = "--";
               this.name_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.name_Label2.Click += new System.EventHandler(this.name_Label2_Click);
               // 
               // copy_Button
               // 
               this.copy_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.copy_Button.BackColor = System.Drawing.Color.White;
               this.copy_Button.Enabled = false;
               this.copy_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
               this.copy_Button.Location = new System.Drawing.Point(306, 78);
               this.copy_Button.Name = "copy_Button";
               this.copy_Button.Size = new System.Drawing.Size(108, 23);
               this.copy_Button.TabIndex = 5;
               this.copy_Button.Text = "Copy URL";
               this.copy_Button.UseVisualStyleBackColor = false;
               this.copy_Button.Click += new System.EventHandler(this.copy_Button_Click);
               // 
               // quality_ComboBox
               // 
               this.quality_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.quality_ComboBox.BackColor = System.Drawing.Color.White;
               this.quality_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.quality_ComboBox.Enabled = false;
               this.quality_ComboBox.FormattingEnabled = true;
               this.quality_ComboBox.Location = new System.Drawing.Point(191, 49);
               this.quality_ComboBox.Name = "quality_ComboBox";
               this.quality_ComboBox.Size = new System.Drawing.Size(223, 21);
               this.quality_ComboBox.TabIndex = 3;
               this.quality_ComboBox.EnabledChanged += new System.EventHandler(this.quality_ComboBox_EnabledChanged);
               // 
               // quality_Label
               // 
               this.quality_Label.AutoEllipsis = true;
               this.quality_Label.AutoSize = true;
               this.quality_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.quality_Label.Location = new System.Drawing.Point(140, 52);
               this.quality_Label.Name = "quality_Label";
               this.quality_Label.Size = new System.Drawing.Size(42, 13);
               this.quality_Label.TabIndex = 2;
               this.quality_Label.Text = "Quality:";
               // 
               // name_Label1
               // 
               this.name_Label1.AutoEllipsis = true;
               this.name_Label1.AutoSize = true;
               this.name_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.name_Label1.Location = new System.Drawing.Point(140, 21);
               this.name_Label1.Name = "name_Label1";
               this.name_Label1.Size = new System.Drawing.Size(38, 13);
               this.name_Label1.TabIndex = 0;
               this.name_Label1.Text = "Name:";
               // 
               // video_PictureBox
               // 
               this.video_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
               this.video_PictureBox.BackColor = System.Drawing.Color.Transparent;
               this.video_PictureBox.ErrorImage = global::YouTube_Downloader.Properties.Resources.Image_Error;
               this.video_PictureBox.InitialImage = global::YouTube_Downloader.Properties.Resources.Image_Wait;
               this.video_PictureBox.Location = new System.Drawing.Point(9, 9);
               this.video_PictureBox.Name = "video_PictureBox";
               this.video_PictureBox.Size = new System.Drawing.Size(125, 92);
               this.video_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.video_PictureBox.TabIndex = 11;
               this.video_PictureBox.TabStop = false;
               this.video_PictureBox.Click += new System.EventHandler(this.video_PictureBox_Click);
               // 
               // down_Button
               // 
               this.down_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.down_Button.BackColor = System.Drawing.Color.White;
               this.down_Button.Enabled = false;
               this.down_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
               this.down_Button.Location = new System.Drawing.Point(191, 78);
               this.down_Button.Name = "down_Button";
               this.down_Button.Size = new System.Drawing.Size(108, 23);
               this.down_Button.TabIndex = 4;
               this.down_Button.Text = "Download";
               this.down_Button.UseVisualStyleBackColor = false;
               this.down_Button.Click += new System.EventHandler(this.down_Button_Click);
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel2.Location = new System.Drawing.Point(0, 0);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(447, 4);
               this.panel2.TabIndex = 4;
               this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
               // 
               // logo_PictureBox
               // 
               this.logo_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.logo_PictureBox.Image = global::YouTube_Downloader.Properties.Resources.App_Logo;
               this.logo_PictureBox.Location = new System.Drawing.Point(12, 15);
               this.logo_PictureBox.Name = "logo_PictureBox";
               this.logo_PictureBox.Size = new System.Drawing.Size(90, 90);
               this.logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
               this.logo_PictureBox.TabIndex = 3;
               this.logo_PictureBox.TabStop = false;
               // 
               // mainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.Black;
               this.ClientSize = new System.Drawing.Size(447, 287);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.grop_Panel2);
               this.Controls.Add(this.logo_PictureBox);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.grop_Panel1);
               this.DoubleBuffered = true;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "mainForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "RST YouTube Downloader";
               this.Load += new System.EventHandler(this.mainForm_Load);
               this.panel1.ResumeLayout(false);
               this.grop_Panel1.ResumeLayout(false);
               this.grop_Panel1.PerformLayout();
               this.grop_Panel2.ResumeLayout(false);
               this.grop_Panel2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.video_PictureBox)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.logo_PictureBox)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button get_Button;
        private System.Windows.Forms.TextBox url_TextBox;
        private System.Windows.Forms.Label url_Label;
        private System.Windows.Forms.PictureBox logo_PictureBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button paste_Button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel grop_Panel1;
        private System.Windows.Forms.Panel grop_Panel2;
        private System.Windows.Forms.Label name_Label2;
        private System.Windows.Forms.Button copy_Button;
        private System.Windows.Forms.ComboBox quality_ComboBox;
        private System.Windows.Forms.Label quality_Label;
        private System.Windows.Forms.Label name_Label1;
        private System.Windows.Forms.PictureBox video_PictureBox;
        private System.Windows.Forms.Button down_Button;
        private System.Windows.Forms.Panel panel2;
    }
}