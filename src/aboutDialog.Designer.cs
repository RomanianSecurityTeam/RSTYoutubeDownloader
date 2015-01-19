namespace YouTube_Downloader
{
    partial class aboutDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
               this.panel1 = new System.Windows.Forms.Panel();
               this.ok_Button = new System.Windows.Forms.Button();
               this.title_Label = new System.Windows.Forms.Label();
               this.author_Label = new System.Windows.Forms.Label();
               this.modified_Label = new System.Windows.Forms.Label();
               this.copyright_Label = new System.Windows.Forms.Label();
               this.version_Label = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.Black;
               this.panel1.Controls.Add(this.ok_Button);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.panel1.Location = new System.Drawing.Point(0, 296);
               this.panel1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(363, 48);
               this.panel1.TabIndex = 3;
               this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
               // 
               // ok_Button
               // 
               this.ok_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.ok_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
               this.ok_Button.Location = new System.Drawing.Point(271, 13);
               this.ok_Button.Name = "ok_Button";
               this.ok_Button.Size = new System.Drawing.Size(80, 23);
               this.ok_Button.TabIndex = 2;
               this.ok_Button.Text = "OK";
               this.ok_Button.UseVisualStyleBackColor = true;
               this.ok_Button.Click += new System.EventHandler(this.ok_Button_Click);
               // 
               // title_Label
               // 
               this.title_Label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.title_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.title_Label.Location = new System.Drawing.Point(106, 27);
               this.title_Label.Name = "title_Label";
               this.title_Label.Size = new System.Drawing.Size(245, 33);
               this.title_Label.TabIndex = 6;
               this.title_Label.Text = "{Title}";
               this.title_Label.Click += new System.EventHandler(this.title_Label_Click);
               // 
               // author_Label
               // 
               this.author_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.author_Label.Location = new System.Drawing.Point(12, 137);
               this.author_Label.Name = "author_Label";
               this.author_Label.Size = new System.Drawing.Size(285, 13);
               this.author_Label.TabIndex = 7;
               this.author_Label.Text = "{Author}";
               // 
               // modified_Label
               // 
               this.modified_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.modified_Label.Location = new System.Drawing.Point(12, 160);
               this.modified_Label.Name = "modified_Label";
               this.modified_Label.Size = new System.Drawing.Size(285, 13);
               this.modified_Label.TabIndex = 8;
               this.modified_Label.Text = "{Modified}";
               // 
               // copyright_Label
               // 
               this.copyright_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.copyright_Label.Location = new System.Drawing.Point(12, 183);
               this.copyright_Label.Name = "copyright_Label";
               this.copyright_Label.Size = new System.Drawing.Size(285, 13);
               this.copyright_Label.TabIndex = 9;
               this.copyright_Label.Text = "{Copyright}";
               // 
               // version_Label
               // 
               this.version_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(44)))));
               this.version_Label.Location = new System.Drawing.Point(12, 114);
               this.version_Label.Name = "version_Label";
               this.version_Label.Size = new System.Drawing.Size(285, 13);
               this.version_Label.TabIndex = 7;
               this.version_Label.Text = "{Version}";
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::YouTube_Downloader.Properties.Resources.App_Logo;
               this.pictureBox1.Location = new System.Drawing.Point(12, 12);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(76, 48);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 10;
               this.pictureBox1.TabStop = false;
               // 
               // aboutDialog
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.Black;
               this.ClientSize = new System.Drawing.Size(363, 344);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.copyright_Label);
               this.Controls.Add(this.modified_Label);
               this.Controls.Add(this.version_Label);
               this.Controls.Add(this.author_Label);
               this.Controls.Add(this.title_Label);
               this.Controls.Add(this.panel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "aboutDialog";
               this.ShowIcon = false;
               this.ShowInTaskbar = false;
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Text = "About {AppName}";
               this.panel1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ok_Button;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Label author_Label;
        private System.Windows.Forms.Label modified_Label;
        private System.Windows.Forms.Label copyright_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label version_Label;

    }
}
