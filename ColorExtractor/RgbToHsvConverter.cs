using System.Numerics;

namespace ColorExtractor;

public class RgbToHsvConverter : IColorModelConverter
{
    public Vector3 Convert(Color rgb)
    {
        // https://en.wikipedia.org/wiki/HSL_and_HSV#From_RGB
        var r = rgb.R / 255f;
        var g = rgb.G / 255f;
        var b = rgb.B / 255f;

        var max = Math.Max(r, Math.Max(g, b));
        var min = Math.Min(r, Math.Min(g, b));

        var c = max - min;

        float h;
        if (c == 0) h = 0;
        else if (max == r) h = (g - b) / c % 6;
        else if (max == g) h = (b - r) / c + 2;
        else h = (r - g) / c + 4;

        var s = max == 0 ? 0 : c / max;

        return new Vector3(h * 60, s, max);
    }

    public (Color, Color, Color) Extract(Color rgb)
    {
        var hsv = Convert(rgb);
        var h = (byte)(hsv.X * 255 / 360);
        var s = (byte)(hsv.Y * 255);
        var v = (byte)(hsv.Z * 255);
        return (Color.FromArgb(h, h, h),
            Color.FromArgb(s, s, s),
            Color.FromArgb(v, v, v));
    }

    public (string, string, string) OutputLabels => ("H", "S", "V");

    public override string ToString()
    {
        return "HSV";
    }
}