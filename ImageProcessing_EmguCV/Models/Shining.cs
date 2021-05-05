using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing_EmguCV.Models
{
    public class Shining
    {
        public Bitmap Parlaklık(Bitmap bitmap, int value)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            Color color;
            Color color2;
            int r, b, g;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int x = 0; x < bitmap.Height; x++)
                {
                    color = bitmap.GetPixel(i, x);
                    if (color.R + value > 255)
                    {
                        r = 225;
                    }
                    else if (color.R + value < 0)
                    {
                        r = 0;
                    }
                    else
                    {
                        r = color.R + value;
                    }

                    color = bitmap.GetPixel(i, x);
                    if (color.B + value > 255)
                    {
                        b = 225;
                    }
                    else if (color.B + value < 0)
                    {
                        b = 0;
                    }
                    else
                    {
                        b = color.B + value;
                    }

                    color = bitmap.GetPixel(i, x);
                    if (color.G + value > 255)
                    {
                        g = 225;
                    }
                    else if (color.G + value < 0)
                    {
                        g = 0;
                    }
                    else
                    {
                        g = color.G + value;
                    }

                    color2 = Color.FromArgb(r, g, b);
                    result.SetPixel(i, x, color2);
                }
            }
            return result;
        }
    }
}
