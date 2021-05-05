using ImageProcessing_EmguCV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing_EmguCV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void processingHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramForm histogram = new HistogramForm();
            histogram.Show();
        }

        private void ımageFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void ımageProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessingForm processing = new ProcessingForm();
            processing.Show();
        }
    }
}
