using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing_EmguCV.Models
{
    public class Esikleme
    {
        public Bitmap Esikle(Bitmap bitmap, int esik)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            Color color;
            Color color2;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int x = 0; x < bitmap.Height; x++)
                {
                    color = bitmap.GetPixel(i, x);
                    if (color.R >= esik)
                    {
                        color2 = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        color2 = Color.FromArgb(0, 0, 0);
                    }
                    result.SetPixel(i, x, color2);
                }
            }
            return result;
        }
    }
}
