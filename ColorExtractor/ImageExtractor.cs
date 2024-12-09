namespace ColorExtractor;

public class ImageExtractor(IColorModelConverter converter)
{
    public IColorModelConverter Converter = converter;

    public (Bitmap b0, Bitmap b1, Bitmap b2) Extract(Bitmap image)
    {
        var b0 = new DirectBitmap(image.Width, image.Height);
        var b1 = new DirectBitmap(image.Width, image.Height);
        var b2 = new DirectBitmap(image.Width, image.Height);

        for (var i = 0; i < image.Width; i++)
        {
            for (var j = 0; j < image.Height; j++)
            {
                var rgb = image.GetPixel(i, j);
                var (c0, c1, c2) = Converter.Extract(rgb);
                b0.SetPixel(i, j, c0);
                b1.SetPixel(i, j, c1);
                b2.SetPixel(i, j, c2);
            }
        }

        return (b0.Bitmap, b1.Bitmap, b2.Bitmap);
    }
}