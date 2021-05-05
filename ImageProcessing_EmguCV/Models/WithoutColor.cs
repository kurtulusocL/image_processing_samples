using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing_EmguCV.Models
{
    public class WithoutColor
    {
        public Bitmap ConvertToGrey(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            Color firstColor, secondColor;
            int ton;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int x = 0; x < bitmap.Height; x++)
                {
                    firstColor = bitmap.GetPixel(i, x);
                    ton = Convert.ToInt16(0.299 * firstColor.R) + Convert.ToInt16(0.587 * firstColor.G) + Convert.ToInt16(0.114 * firstColor.B);
                    secondColor = Color.FromArgb(ton, ton, ton);
                    result.SetPixel(i, x, secondColor);
                }
            }
            return result;
        }
    }
}
