
namespace CityViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbCityes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbArrrowLeft = new System.Windows.Forms.Label();
            this.lbArrowRigth = new System.Windows.Forms.Label();
            this.pbImageCity = new System.Windows.Forms.PictureBox();
            this.lbNameCity = new System.Windows.Forms.Label();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageCity)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCityes
            // 
            this.cbCityes.FormattingEnabled = true;
            this.cbCityes.Location = new System.Drawing.Point(3, 13);
            this.cbCityes.Name = "cbCityes";
            this.cbCityes.Size = new System.Drawing.Size(197, 28);
            this.cbCityes.TabIndex = 0;
            this.cbCityes.SelectedIndexChanged += new System.EventHandler(this.cbCityes_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lbArrrowLeft);
            this.panel1.Controls.Add(this.lbArrowRigth);
            this.panel1.Controls.Add(this.pbImageCity);
            this.panel1.Controls.Add(this.lbNameCity);
            this.panel1.Location = new System.Drawing.Point(216, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 425);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(221, 362);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 41);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link Wiki";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbArrrowLeft
            // 
            this.lbArrrowLeft.Image = ((System.Drawing.Image)(resources.GetObject("lbArrrowLeft.Image")));
            this.lbArrrowLeft.Location = new System.Drawing.Point(-2, 192);
            this.lbArrrowLeft.Name = "lbArrrowLeft";
            this.lbArrrowLeft.Size = new System.Drawing.Size(65, 39);
            this.lbArrrowLeft.TabIndex = 3;
            this.lbArrrowLeft.Click += new System.EventHandler(this.lbArrrowLeft_Click);
            // 
            // lbArrowRigth
            // 
            this.lbArrowRigth.Image = ((System.Drawing.Image)(resources.GetObject("lbArrowRigth.Image")));
            this.lbArrowRigth.Location = new System.Drawing.Point(508, 192);
            this.lbArrowRigth.Name = "lbArrowRigth";
            this.lbArrowRigth.Size = new System.Drawing.Size(62, 39);
            this.lbArrowRigth.TabIndex = 2;
            this.lbArrowRigth.Click += new System.EventHandler(this.lbArrowRigth_Click);
            // 
            // pbImageCity
            // 
            this.pbImageCity.Location = new System.Drawing.Point(137, 92);
            this.pbImageCity.Name = "pbImageCity";
            this.pbImageCity.Size = new System.Drawing.Size(310, 267);
            this.pbImageCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImageCity.TabIndex = 1;
            this.pbImageCity.TabStop = false;
            // 
            // lbNameCity
            // 
            this.lbNameCity.AutoSize = true;
            this.lbNameCity.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbNameCity.Location = new System.Drawing.Point(230, 13);
            this.lbNameCity.Name = "lbNameCity";
            this.lbNameCity.Size = new System.Drawing.Size(0, 41);
            this.lbNameCity.TabIndex = 0;
            // 
            // ssInfo
            // 
            this.ssInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssInfo.Location = new System.Drawing.Point(0, 428);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(800, 22);
            this.ssInfo.TabIndex = 2;
            this.ssInfo.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbCityes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCityes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbArrrowLeft;
        private System.Windows.Forms.Label lbArrowRigth;
        private System.Windows.Forms.PictureBox pbImageCity;
        private System.Windows.Forms.Label lbNameCity;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.StatusStrip ssInfo;
    }
}

