
namespace FaceRecognitionPhoto
{
    partial class FaceRecognitionForm
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDeleteEducate = new System.Windows.Forms.Button();
            this.txtFaceName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblEgitilenAdet = new System.Windows.Forms.Label();
            this.btnEducate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(718, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // btnDeleteEducate
            // 
            this.btnDeleteEducate.Location = new System.Drawing.Point(718, 237);
            this.btnDeleteEducate.Name = "btnDeleteEducate";
            this.btnDeleteEducate.Size = new System.Drawing.Size(102, 52);
            this.btnDeleteEducate.TabIndex = 12;
            this.btnDeleteEducate.Text = "Tüm Eğitimleri Sil";
            this.btnDeleteEducate.UseVisualStyleBackColor = true;
            this.btnDeleteEducate.Click += new System.EventHandler(this.btnDeleteEducate_Click);
            // 
            // txtFaceName
            // 
            this.txtFaceName.Location = new System.Drawing.Point(718, 70);
            this.txtFaceName.Name = "txtFaceName";
            this.txtFaceName.Size = new System.Drawing.Size(102, 20);
            this.txtFaceName.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(718, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblEgitilenAdet
            // 
            this.lblEgitilenAdet.AutoSize = true;
            this.lblEgitilenAdet.Location = new System.Drawing.Point(718, 96);
            this.lblEgitilenAdet.Name = "lblEgitilenAdet";
            this.lblEgitilenAdet.Size = new System.Drawing.Size(29, 13);
            this.lblEgitilenAdet.TabIndex = 9;
            this.lblEgitilenAdet.Text = "Adet";
            // 
            // btnEducate
            // 
            this.btnEducate.Location = new System.Drawing.Point(718, 12);
            this.btnEducate.Name = "btnEducate";
            this.btnEducate.Size = new System.Drawing.Size(102, 52);
            this.btnEducate.TabIndex = 8;
            this.btnEducate.Text = "Yüz Eğit\n(10 Adet)";
            this.btnEducate.UseVisualStyleBackColor = true;
            this.btnEducate.Click += new System.EventHandler(this.btnEducate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FaceRecognitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 489);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnDeleteEducate);
            this.Controls.Add(this.txtFaceName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEgitilenAdet);
            this.Controls.Add(this.btnEducate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FaceRecognitionForm";
            this.Text = "FaceRecognitionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaceRecognitionForm_FormClosing);
            this.Load += new System.EventHandler(this.FaceRecognitionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnDeleteEducate;
        private System.Windows.Forms.TextBox txtFaceName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEgitilenAdet;
        private System.Windows.Forms.Button btnEducate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}