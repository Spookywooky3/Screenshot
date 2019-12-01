using System.Drawing.Imaging;

namespace Screenshot_Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Screenshot.Screenshot screenshot = new Screenshot.Screenshot();
            screenshot.TakeScreenshot(1920, 1080, true, true, @"D:\\test.jpg", ImageFormat.Jpeg);
        }
    }
}