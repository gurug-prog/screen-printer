using System;
using System.Drawing;
using System.Drawing.Imaging;
//using System.Windows.Forms;

try
{
    //Creating a new Bitmap object
    Bitmap captureBitmap = new Bitmap(775, 415, PixelFormat.Format32bppArgb);
    //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
    //Creating a Rectangle object which will
    //capture our Current Screen
    Rectangle captureRectangle = new Rectangle
    {
        X = 565,
        Y = 260,
        Width = captureBitmap.Width,
        Height = captureBitmap.Height,
    };

    //Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
    //Creating a New Graphics Object
    Graphics captureGraphics = Graphics.FromImage(captureBitmap);

    // Delay
    System.Threading.Thread.Sleep(2000);

    //Copying Image from The Screen
    //captureGraphics.CopyFromScreen(600, 400, 1000, 800, captureRectangle.Size);
    captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
    //Saving the Image File (I am here Saving it in My E drive).
    //captureBitmap.Save(@"C:\Users\admin\Desktop\Capture.jpg", ImageFormat.Jpeg);
    captureBitmap.Save(@"C:\Users\admin\Desktop\Capture.PNG", ImageFormat.Png);
    //captureBitmap.Save(@"C:\Users\admin\Desktop\курси не бачу\csharp-starter\10.PNG", ImageFormat.Png);
    captureBitmap.Save(@"C:\Users\admin\Desktop\курси не бачу\csharp-starter\output.PNG", ImageFormat.Png);
    //Displaying the Successfull Result
    Console.WriteLine("Screen Captured");
}
catch (Exception ex)
{
    Console.Error.WriteLine(ex.Message);
}
