using System.Numerics;

namespace ColorExtractor;

public interface IColorModelConverter
{
    public (string, string, string) OutputLabels { get; }
    public Vector3 Convert(Color rgb);
    public (Color, Color, Color) Extract(Color rgb);
}