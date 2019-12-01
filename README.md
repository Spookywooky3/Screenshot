[![CodeFactor](https://img.shields.io/codefactor/grade/github/spookywooky3/screenshot) [![Build Status](https://travis-ci.org/Spookywooky3/Screenshot.svg?branch=master)](https://travis-ci.org/Spookywooky3/Screenshot)
# Screenshot
This is a quick screenshot library I made for a project I'm currently developing, I plan to add more features to here in the future.

## Usage
```csharp
using Screenshot;
...
private void Screenshot()
{
    Screenshot.Screenshot screenshot = new Screenshot.Screenshot();
    screenshot.TakeScreenshot(1920, 1080, true, true, @"D:\\test.jpg", ImageFormat.Jpeg);
}
```
## Contributing
Feel free to contribute, it's always welcome.
