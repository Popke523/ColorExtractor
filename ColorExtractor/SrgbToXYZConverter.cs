using System.Numerics;

namespace ColorExtractor;

public class SrgbToXYZConverter : IRgbToXyzConverter
{
    public float Xw => 0.95047f;
    public float Yw => 1.0f;
    public float Zw => 1.08883f;

    public Vector3 Convert(Color rgb)
    {
        var r = rgb.R / 255f;
        var g = rgb.G / 255f;
        var b = rgb.B / 255f;
        
        var rLinear = MathF.Pow(r, 2.2f);
        var gLinear = MathF.Pow(g, 2.2f);
        var bLinear = MathF.Pow(b, 2.2f);

        var x = 0.4124564f * rLinear + 0.3575761f * gLinear + 0.1804375f * bLinear;
        var y = 0.2126729f * rLinear + 0.7151522f * gLinear + 0.0721750f * bLinear;
        var z = 0.0193339f * rLinear + 0.1191920f * gLinear + 0.9503041f * bLinear;

        return new Vector3(x, y, z);
    }

    public override string ToString()
    {
        return "sRGB";
    }
}