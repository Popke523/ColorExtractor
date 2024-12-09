using System.Numerics;

namespace ColorExtractor;

public class RgbToLabConverter(IRgbToXyzConverter rgbToXyzConverter) : IColorModelConverter
{
    public IRgbToXyzConverter RgbToXyzConverter { get; set; } = rgbToXyzConverter;

    public Vector3 Convert(Color rgb)
    {
        var xyz = RgbToXyzConverter.Convert(rgb);
        var x = xyz.X / RgbToXyzConverter.Xw;
        var y = xyz.Y / RgbToXyzConverter.Yw;
        var z = xyz.Z / RgbToXyzConverter.Zw;

        x = x > 0.008856f ? MathF.Pow(x, 1f / 3f) : (903.3f * x + 16f) / 116f;
        y = y > 0.008856f ? MathF.Pow(y, 1f / 3f) : (903.3f * y + 16f) / 116f;
        z = z > 0.008856f ? MathF.Pow(z, 1f / 3f) : (903.3f * z + 16f) / 116f;

        var l = 116f * y - 16f;
        var a = 500f * (x - y);
        var b = 200f * (y - z);

        return new Vector3(l, a, b);
    }

    public (Color, Color, Color) Extract(Color rgb)
    {
        var Lab = Convert(rgb);

        var l = (byte)(Lab.X * 255 / 100f);
        var a = (byte)(Lab.Y + 127);
        var b = (byte)(Lab.Z + 127);

        var grayL = Color.FromArgb(l, l, l);
        var colorA = Color.FromArgb(a, 255 - a, 127);
        var colorB = Color.FromArgb(b, 127, 255 - b);

        return (grayL, colorA, colorB);
    }

    public (string, string, string) OutputLabels => ("L", "a", "b");


    public override string ToString()
    {
        return "Lab";
    }
}