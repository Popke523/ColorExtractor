using System.Numerics;

namespace ColorExtractor;

public class WideGamutToXYZConverter : IRgbToXyzConverter
{
    public float Xw => 0.96422f;
    public float Yw => 1.0f;
    public float Zw => 0.82521f;

    public Vector3 Convert(Color rgb)
    {
        var r = rgb.R / 255f;
        var g = rgb.G / 255f;
        var b = rgb.B / 255f;
        
        var rLinear = MathF.Pow(r, 2.2f);
        var gLinear = MathF.Pow(g, 2.2f);
        var bLinear = MathF.Pow(b, 2.2f);

        var x = 0.7161046f * rLinear + 0.1009296f * gLinear + 0.1471858f * bLinear;
        var y = 0.2581874f * rLinear + 0.7249378f * gLinear + 0.0168748f * bLinear;
        var z = 0.0000000f * rLinear + 0.0517813f * gLinear + 0.7734287f * bLinear;

        return new Vector3(x, y, z);
    }

    public override string ToString()
    {
        return "Wide Gamut RGB";
    }
}