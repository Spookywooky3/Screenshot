# Screenshot
This is a quick screenshot library I made for a project I'm currently developing, I plan to add more features to here in the future.

## Usage
```csharp
using Screenshot;
using System.Drawing.Imaging;
...
private void Screenshot()
{
    Screenshot.Screenshot screenshot = new Screenshot.Screenshot();
    screenshot.TakeScreenshot(1920, 1080, true, true, @"D:\\test.jpg", ImageFormat.Jpeg);
}
```
## Contributing feel free to contribute, it's always welcome.
