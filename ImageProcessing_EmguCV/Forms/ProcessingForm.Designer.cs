
namespace ImageProcessing_EmguCV.Forms
{
    partial class ProcessingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.picBoxCamera = new System.Windows.Forms.PictureBox();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.picBoxUpload = new System.Windows.Forms.PictureBox();
            this.btnCatchImage = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Computer Cameras:";
            // 
            // cmbCamera
            // 
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(136, 12);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(176, 21);
            this.cmbCamera.TabIndex = 7;
            // 
            // picBoxCamera
            // 
            this.picBoxCamera.Location = new System.Drawing.Point(12, 52);
            this.picBoxCamera.Name = "picBoxCamera";
            this.picBoxCamera.Size = new System.Drawing.Size(294, 288);
            this.picBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCamera.TabIndex = 9;
            this.picBoxCamera.TabStop = false;
            // 
            // picBoxImage
            // 
            this.picBoxImage.Location = new System.Drawing.Point(324, 52);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(294, 288);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImage.TabIndex = 9;
            this.picBoxImage.TabStop = false;
            // 
            // picBoxUpload
            // 
            this.picBoxUpload.Location = new System.Drawing.Point(624, 52);
            this.picBoxUpload.Name = "picBoxUpload";
            this.picBoxUpload.Size = new System.Drawing.Size(294, 288);
            this.picBoxUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUpload.TabIndex = 9;
            this.picBoxUpload.TabStop = false;
            // 
            // btnCatchImage
            // 
            this.btnCatchImage.Location = new System.Drawing.Point(324, 10);
            this.btnCatchImage.Name = "btnCatchImage";
            this.btnCatchImage.Size = new System.Drawing.Size(136, 23);
            this.btnCatchImage.TabIndex = 10;
            this.btnCatchImage.Text = "Catch Image On Camera";
            this.btnCatchImage.UseVisualStyleBackColor = true;
            this.btnCatchImage.Click += new System.EventHandler(this.btnCatchImage_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(592, 10);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(75, 23);
            this.btnUploadImage.TabIndex = 10;
            this.btnUploadImage.Text = "Open Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(466, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Catched Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 366);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnCatchImage);
            this.Controls.Add(this.picBoxUpload);
            this.Controls.Add(this.picBoxImage);
            this.Controls.Add(this.picBoxCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCamera);
            this.Name = "ProcessingForm";
            this.Text = "ProcessingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessingForm_FormClosing);
            this.Load += new System.EventHandler(this.ProcessingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.PictureBox picBoxCamera;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.PictureBox picBoxUpload;
        private System.Windows.Forms.Button btnCatchImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnSave;
    }
}