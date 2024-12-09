using System.Numerics;

namespace ColorExtractor;

public class ImageFactory
{
    public static Bitmap CreateTestImage()
    {
        var bitmap = new DirectBitmap(720, 200);
        var converter = new HsvToRgbConverter();

        for (int i = 0; i < bitmap.Width; i++)
        {
            for (int j = 0; j < bitmap.Height; j++)
            {
                bitmap.SetPixel(i, j, (i/16 + j/16) % 2 == 0 ? Color.White : Color.Black);
            }
        }

        for(int i = 0; i < 360; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                bitmap.SetPixel(i+180, j+50, converter.Convert(new Vector3(i, 1-(j / 100.0f), 1.0f)));
            }
        }

        return bitmap.Bitmap;
    }
}