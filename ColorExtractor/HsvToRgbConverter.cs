using System.Numerics;

namespace ColorExtractor;

public class HsvToRgbConverter
{
    // https://en.wikipedia.org/wiki/HSL_and_HSV#From_HSV
    public Color Convert(Vector3 hsv)
    {
        var h = hsv.X / 60;
        var s = hsv.Y;
        var v = hsv.Z;
        var c = v * s;
        var x = c * (1 - Math.Abs(h % 2 - 1));
        var m = v - c;
        float r, g, b;
        if (h < 1) (r, g, b) = (c, x, 0);
        else if (h < 2) (r, g, b) = (x, c, 0);
        else if (h < 3) (r, g, b) = (0, c, x);
        else if (h < 4) (r, g, b) = (0, x, c);
        else if (h < 5) (r, g, b) = (x, 0, c);
        else (r, g, b) = (c, 0, x);
        return Color.FromArgb((byte)((r + m) * 255),
            (byte)((g + m) * 255),
            (byte)((b + m) * 255));
    }
}

