using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Screenshot
{
    /// <summary>
    /// Use this class to take screenshots.
    /// </summary>
    public class Screenshot
    {
        /// <summary>
        /// Take Screenshot.
        /// </summary>
        /// <param name="width">Width of the screenshot.</param>
        /// <param name="height">Height of the screenshot.</param>
        /// <param name="open">Open the screenshot?</param>
        /// <param name="save">Save the screenshot?</param>
        /// <param name="saveLocation">Location to save (Leave null if save is false).</param>
        /// <param name="format">The ImageFormat to save as.</param>
        /// <returns></returns>
        public void TakeScreenshot(int width, int height, bool open, bool save, string saveLocation = null, ImageFormat format = null)
        {
            Rectangle size;
            size.Width = width;
            size.Height = height;
            using (Bitmap bitmap = new Bitmap(width, height))
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(new Point(size.Left, size.Top), Point.Empty, size.Size);

                if (save == true)
                {
                    bitmap.Save(saveLocation, format);
                }
                if (open == true)
                {
                    bitmap.Save($"{Path.GetTempPath()}\\bitmap.jpg", ImageFormat.Jpeg);
                    Process p = new Process();
                    p.StartInfo.FileName = $"{Path.GetTempPath()}\\bitmap.jpg";
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="width">Width of the screenshot.</param>
        /// <param name="height">Height of the screenshot.</param>
        /// <returns>Returns a bitmap.</returns>
        public Bitmap TakeBitmapScreenshot(int width, int height)
        {
            Rectangle size;
            size.Width = width;
            size.Height = height;
            using (Bitmap bitmap = new Bitmap(width, height))
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(new Point(size.Left, size.Top), Point.Empty, size.Size);
                return bitmap;
            }
        }
    }
}
