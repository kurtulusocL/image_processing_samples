
namespace ImageProcessing_EmguCV
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.processingHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processingHistogramToolStripMenuItem,
            this.ımageFilterToolStripMenuItem,
            this.ımageProcessingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processingHistogramToolStripMenuItem
            // 
            this.processingHistogramToolStripMenuItem.Name = "processingHistogramToolStripMenuItem";
            this.processingHistogramToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.processingHistogramToolStripMenuItem.Text = "Processing / Histogram";
            this.processingHistogramToolStripMenuItem.Click += new System.EventHandler(this.processingHistogramToolStripMenuItem_Click);
            // 
            // ımageFilterToolStripMenuItem
            // 
            this.ımageFilterToolStripMenuItem.Name = "ımageFilterToolStripMenuItem";
            this.ımageFilterToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ımageFilterToolStripMenuItem.Text = "Image Filter";
            this.ımageFilterToolStripMenuItem.Click += new System.EventHandler(this.ımageFilterToolStripMenuItem_Click);
            // 
            // ımageProcessingToolStripMenuItem
            // 
            this.ımageProcessingToolStripMenuItem.Name = "ımageProcessingToolStripMenuItem";
            this.ımageProcessingToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.ımageProcessingToolStripMenuItem.Text = "Image Processing";
            this.ımageProcessingToolStripMenuItem.Click += new System.EventHandler(this.ımageProcessingToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processingHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ımageFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ımageProcessingToolStripMenuItem;
    }
}