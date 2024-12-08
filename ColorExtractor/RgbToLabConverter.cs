using System.Numerics;

namespace ColorExtractor;

public class RgbToLabConverter:IColorModelConverter
{
    public Vector3 Convert(Color rgb)
    {
        throw new NotImplementedException();
    }

    public (Color, Color, Color) Extract(Color rgb)
    {
        throw new NotImplementedException();
    }
}