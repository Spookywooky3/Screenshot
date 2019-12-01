using System.Drawing.Imaging;
using System.Drawing;

namespace Screenshot_Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Screenshot.Screenshot screenshot = new Screenshot.Screenshot();

            /* Take the screenshot without any return */
            screenshot.TakeScreenshot(1920, 1080, true, true, @"D:\test.jpg", ImageFormat.Jpeg);

            Bitmap bitmap = screenshot.TakeBitmapScreenshot(1920, 1080);
            /* Do whatever you want with the bitmap */
            bitmap.Save(@"D:\test.jpg", ImageFormat.Jpeg);
        }
    }
}