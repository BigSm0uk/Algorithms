using System.Drawing;

namespace Algorithms.CodeWars;

public static class RGBToHexConversion
{
    public static string Rgb(int r, int g, int b)
    {
        if (r > 255) r = 255;
        if (g > 255) g = 255;
        if (b > 255) b = 255;
        if (r < 0) r = 0;
        if (g < 0) g = 0;
        if (b < 0) b = 0;
        var myColor = Color.FromArgb(r, g, b);
        var hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
        return hex;
    }

    public static void Main()
    {
        Console.WriteLine(Rgb(255, 255, 300));
    }
}