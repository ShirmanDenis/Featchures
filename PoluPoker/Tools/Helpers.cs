using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PoluPoker.Tools
{
    class Helpers
    {
        public static Image SetImageOpacity(Image image, float opacity)
        {
            try
            {
                //create a Bitmap the size of the image provided  
                var bmp = new Bitmap(image.Width, image.Height);

                //create a graphics object from the image  
                using (var gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    var matrix = new ColorMatrix
                    {
                        Matrix33 = opacity
                    };

                    //set the opacity  

                    //create image attributes  
                    var attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
