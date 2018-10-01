using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorikeet
{
    class ImageHelper
    {
        public static Image GetDeleteImage()
        {
            return GetImage(Brushes.Red);
        }

        public static Image GetEditImage()
        {
            return GetImage(Brushes.Green);
        }

        public static Image GetImage(Brush b)
        {
            Image img = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(img))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillEllipse(b, new Rectangle(0, 0, img.Width - 1, img.Height - 1));
            }
            return img;
        }
    }
}
