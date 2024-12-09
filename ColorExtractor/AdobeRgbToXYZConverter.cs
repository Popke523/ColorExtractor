using System.Numerics;

namespace ColorExtractor;

public class AdobeRgbToXYZConverter : IRgbToXyzConverter
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

        var x = 0.5767309f * rLinear + 0.1855540f * gLinear + 0.1881852f * bLinear;
        var y = 0.2973769f * rLinear + 0.6273491f * gLinear + 0.0752741f * bLinear;
        var z = 0.0270343f * rLinear + 0.0706872f * gLinear + 0.9911085f * bLinear;

        return new Vector3(x, y, z);
    }

    public override string ToString()
    {
        return "Adobe RGB";
    }
}