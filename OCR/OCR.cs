using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_s_Apex_Power.OCR
{
    class OCR
    {
        //截图    没写完！！！！！
        public static Image CopyScreen()
        {
            Bitmap bmp = new Bitmap(1920, 1080);//(410, 50);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(new Point(0, 1510), new Point(0, 1030), new Size(bmp.Width, bmp.Height));
            bmp.Save(@"./guns.png", System.Drawing.Imaging.ImageFormat.Png);
            return bmp;

        }
    }
}
