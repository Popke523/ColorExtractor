using System.Numerics;

namespace ColorExtractor;

public class RgbToYCbCrConverter : IColorModelConverter
{
    public Vector3 Convert(Color rgb)
    {
        var r = rgb.R / 255f;
        var g = rgb.G / 255f;
        var b = rgb.B / 255f;

        var y = 0.299f * r + 0.587f * g + 0.114f * b;
        var cb = (b - y) / 1.772f + 0.5f;
        var cr = (r - y) / 1.402f + 0.5f;

        return new Vector3(y, cb, cr);
    }


    public (Color, Color, Color) Extract(Color rgb)
    {
        var yCbCr = Convert(rgb);
        var y = (byte)(yCbCr.X * 255);
        var cb = (byte)(yCbCr.Y * 255);
        var cr = (byte)(yCbCr.Z * 255);

        return (Color.FromArgb(y, y, y),
                Color.FromArgb(127, 255 - cb, cb),
                Color.FromArgb(cr, 255 - cr, 127)
            );
    }

    public (string, string, string) OutputLabels => ("Y", "Cb", "Cr");


    public override string ToString()
    {
        return "YCbCr";
    }
}