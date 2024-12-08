using System.Numerics;

namespace ColorExtractor;

public interface IColorModelConverter
{
    public Vector3 Convert(Color rgb);
    public (Color, Color, Color) Extract(Color rgb);
}