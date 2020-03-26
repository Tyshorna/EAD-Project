namespace EADProject
{
    partial class FrmCitizen_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitizen_Report));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCrime = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboCrimeCommitted = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Navy;
            this.btnSubmit.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.Location = new System.Drawing.Point(714, 382);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 31);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(297, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report";
            // 
            // lblCrime
            // 
            this.lblCrime.AutoSize = true;
            this.lblCrime.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrime.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCrime.Location = new System.Drawing.Point(36, 230);
            this.lblCrime.Name = "lblCrime";
            this.lblCrime.Size = new System.Drawing.Size(226, 35);
            this.lblCrime.TabIndex = 3;
            this.lblCrime.Text = "Crime Committed";
            this.lblCrime.Click += new System.EventHandler(this.lblCrime_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLocation.Location = new System.Drawing.Point(36, 294);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(118, 35);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(262, 300);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(231, 20);
            this.txtLocation.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDescription.Location = new System.Drawing.Point(36, 348);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(154, 35);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(251, 354);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(436, 137);
            this.rtxtDescription.TabIndex = 12;
            this.rtxtDescription.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(284, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Location = new System.Drawing.Point(714, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 31);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboCrimeCommitted
            // 
            this.cboCrimeCommitted.FormattingEnabled = true;
            this.cboCrimeCommitted.Items.AddRange(new object[] {
            "Animal Cruelty",
            "Aiding and Abetting",
            "Assault",
            "Bank Fraud",
            "Battery",
            "Blackmail",
            "Burglary",
            "Child Abuse",
            "Child Pornography",
            "Credit Card Fraud",
            "Cyber Crime",
            "Domestic Abuse",
            "Driving on a Suspended or Revoked License",
            "Driving under the Influence of Alcohol",
            "Driving without a License",
            "Drug Abuse",
            "Drug Manufacturing",
            "Drug Possession",
            "Drug Trafficking",
            "Embezzlement",
            "Extortion",
            "Forgery",
            "Hit-and-Run Accident",
            "Homicide",
            "Insurance Fraud",
            "Kidnapping",
            "Larceny",
            "Manslaughter",
            "Minor in Possession of Alcohol",
            "Money Counterfeiting",
            "Money Laundering",
            "Murder",
            "Perjury",
            "Public Intoxication",
            "Rape",
            "Reckless Driving",
            "Robbery",
            "Securities Fraud",
            "Supplying Alcohol to Minors",
            "Shoplifting",
            "Tax Evasion",
            "Tax Fraud",
            "Theft",
            "Vehicular Assault"});
            this.cboCrimeCommitted.Location = new System.Drawing.Point(262, 244);
            this.cboCrimeCommitted.Name = "cboCrimeCommitted";
            this.cboCrimeCommitted.Size = new System.Drawing.Size(231, 21);
            this.cboCrimeCommitted.TabIndex = 17;
            // 
            // FrmCitizen_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(844, 519);
            this.Controls.Add(this.cboCrimeCommitted);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCrime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "FrmCitizen_Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCrime;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboCrimeCommitted;
    }
}