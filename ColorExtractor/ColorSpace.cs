namespace ColorExtractor;

public class ColorSpace
{
    public string? Name { get; set; }
    
    public float Xr { get; set; }
    public float Yr { get; set; }
    
    public float Xg { get; set; }
    public float Yg { get; set; }
    
    public float Xb { get; set; }
    public float Yb { get; set; }
    
    public float Xw { get; set; }
    public float Yw { get; set; }
    
    public float Gamma { get; set; }

    public float ConvertRgbToXyz(Color rgb)
    {
        throw new NotImplementedException();
    }
}