using System.Numerics;

namespace ColorExtractor;

public interface IRgbToXyzConverter
{
    public float Xw { get; }
    public float Yw { get; }
    public float Zw { get; }
    public Vector3 Convert(Color rgb);
}