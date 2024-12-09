using System.Numerics;

namespace ColorExtractor;

public class CustomRgbToXyzConverter : IRgbToXyzConverter
{
    private readonly float Sb;
    private readonly float Sg;
    private readonly float Sr;
    private readonly float Xb;
    private readonly float Xg;
    private readonly float Xr;
    private readonly float Yb;
    private readonly float Yg;
    private readonly float Yr;
    private readonly float Zb;
    private readonly float Zg;
    private readonly float Zr;
    private readonly float gamma;

    public CustomRgbToXyzConverter()
    {
    }

    public CustomRgbToXyzConverter(float xr, float yr, float xg, float yg, float xb, float yb, float xw, float yw,
        float gamma)
    {
        Xr = xr / yr;
        Yr = 1;
        Zr = (1 - xr - yr) / yr;
        Xg = xg / yg;
        Yg = 1;
        Zg = (1 - xg - yg) / yg;
        Xb = xb / yb;
        Yb = 1;
        Zb = (1 - xb - yb) / yb;
        Xw = xw / yw;
        Yw = 1;
        Zw = (1 - xw - yw) / yw;

        float[,] M =
        {
            { Xr, Xg, Xb, Xw },
            { Yr, Yg, Yb, Yw },
            { Zr, Zg, Zb, Zw }
        };

        if (!LinearEquationSolver.Solve(M))
            throw new InvalidOperationException("The system of linear equations has no unique solution.");

        Sr = M[0, 3];
        Sg = M[1, 3];
        Sb = M[2, 3];

        this.gamma = gamma;
    }

    public float Xw { get; }
    public float Yw { get; }
    public float Zw { get; }


    public Vector3 Convert(Color rgb)
    {
        var r = rgb.R / 255f;
        var g = rgb.G / 255f;
        var b = rgb.B / 255f;

        var rLinear = MathF.Pow(r, gamma);
        var gLinear = MathF.Pow(g, gamma);
        var bLinear = MathF.Pow(b, gamma);

        var X = Sr * Xr * rLinear + Sg * Xg * gLinear + Sb * Xb * bLinear;
        var Y = Sr * Yr * rLinear + Sg * Yg * gLinear + Sb * Yb * bLinear;
        var Z = Sr * Zr * rLinear + Sg * Zg * gLinear + Sb * Zb * bLinear;

        return new Vector3(X, Y, Z);
    }
    
    public override string ToString()
    {
        return "Custom";
    }
}