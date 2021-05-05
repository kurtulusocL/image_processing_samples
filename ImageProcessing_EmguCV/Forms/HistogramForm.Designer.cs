
namespace ImageProcessing_EmguCV.Forms
{
    partial class HistogramForm
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
            this.btnHistogram_2 = new System.Windows.Forms.Button();
            this.btnHistogram_1 = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistogram_2
            // 
            this.btnHistogram_2.Location = new System.Drawing.Point(19, 327);
            this.btnHistogram_2.Name = "btnHistogram_2";
            this.btnHistogram_2.Size = new System.Drawing.Size(75, 53);
            this.btnHistogram_2.TabIndex = 10;
            this.btnHistogram_2.Text = "Gray Image Histogram";
            this.btnHistogram_2.UseVisualStyleBackColor = true;
            this.btnHistogram_2.Click += new System.EventHandler(this.btnHistogram_2_Click);
            // 
            // btnHistogram_1
            // 
            this.btnHistogram_1.Location = new System.Drawing.Point(19, 230);
            this.btnHistogram_1.Name = "btnHistogram_1";
            this.btnHistogram_1.Size = new System.Drawing.Size(75, 54);
            this.btnHistogram_1.TabIndex = 11;
            this.btnHistogram_1.Text = "Colorfull Image Histogram";
            this.btnHistogram_1.UseVisualStyleBackColor = true;
            this.btnHistogram_1.Click += new System.EventHandler(this.btnHistogram_1_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(19, 137);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 57);
            this.btnGray.TabIndex = 12;
            this.btnGray.Text = "Convert Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(19, 42);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 64);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Open Image File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // histogramBox2
            // 
            this.histogramBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.histogramBox2.Location = new System.Drawing.Point(434, 267);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(290, 240);
            this.histogramBox2.TabIndex = 7;
            // 
            // histogramBox1
            // 
            this.histogramBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.histogramBox1.Location = new System.Drawing.Point(434, 12);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(290, 235);
            this.histogramBox1.TabIndex = 8;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(127, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(290, 235);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 6;
            this.imageBox1.TabStop = false;
            // 
            // HistogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 516);
            this.Controls.Add(this.btnHistogram_2);
            this.Controls.Add(this.btnHistogram_1);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.imageBox1);
            this.Name = "HistogramForm";
            this.Text = "HistogramForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHistogram_2;
        private System.Windows.Forms.Button btnHistogram_1;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}