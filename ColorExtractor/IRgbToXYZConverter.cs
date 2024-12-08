using System.Numerics;

namespace ColorExtractor;

public interface IRgbToXyzConverter
{
    public Vector3 Convert(Color rgb);
}