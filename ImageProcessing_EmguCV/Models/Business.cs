using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing_EmguCV.Models
{
    public class Business
    {
        public Bitmap Negative(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            Color firstColor, secondColor;
            int red, green, blue;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int x = 0; x < bitmap.Height; x++)
                {
                    firstColor = bitmap.GetPixel(i, x);
                    red = 255 - firstColor.R;
                    green = 255 - firstColor.G;
                    blue = 255 - firstColor.B;

                    secondColor = Color.FromArgb(red, green, blue);
                    result.SetPixel(i, x, secondColor);
                }
            }
            return result;
        }
    }
}
