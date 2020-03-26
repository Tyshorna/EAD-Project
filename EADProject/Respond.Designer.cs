namespace EADProject
{
    partial class FrmRespond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRespond));
            this.lblRespond = new System.Windows.Forms.Label();
            this.rtxtRespond = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRespond_Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRespond
            // 
            this.lblRespond.AutoSize = true;
            this.lblRespond.Font = new System.Drawing.Font("Sitka Text", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespond.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRespond.Location = new System.Drawing.Point(276, 221);
            this.lblRespond.Name = "lblRespond";
            this.lblRespond.Size = new System.Drawing.Size(141, 42);
            this.lblRespond.TabIndex = 0;
            this.lblRespond.Text = "Respond";
            this.lblRespond.Click += new System.EventHandler(this.lblRespond_Click);
            // 
            // rtxtRespond
            // 
            this.rtxtRespond.Location = new System.Drawing.Point(41, 322);
            this.rtxtRespond.Name = "rtxtRespond";
            this.rtxtRespond.Size = new System.Drawing.Size(597, 172);
            this.rtxtRespond.TabIndex = 1;
            this.rtxtRespond.Text = "";
            this.rtxtRespond.TextChanged += new System.EventHandler(this.rtxtRespond_TextChanged);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Navy;
            this.btnPost.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPost.Location = new System.Drawing.Point(546, 510);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 31);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "&Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblRespond_Message
            // 
            this.lblRespond_Message.AutoSize = true;
            this.lblRespond_Message.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespond_Message.Location = new System.Drawing.Point(36, 291);
            this.lblRespond_Message.Name = "lblRespond_Message";
            this.lblRespond_Message.Size = new System.Drawing.Size(364, 28);
            this.lblRespond_Message.TabIndex = 4;
            this.lblRespond_Message.Text = "You are responding to the tip you got.";
            // 
            // FrmRespond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(687, 553);
            this.Controls.Add(this.lblRespond_Message);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.rtxtRespond);
            this.Controls.Add(this.lblRespond);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "FrmRespond";
            this.Text = "Respond";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRespond;
        private System.Windows.Forms.RichTextBox rtxtRespond;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRespond_Message;
    }
}