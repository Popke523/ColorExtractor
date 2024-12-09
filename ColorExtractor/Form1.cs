namespace ColorExtractor;

public partial class Form1 : Form
{
    public Bitmap b0;
    public Bitmap b1;
    public Bitmap b2;
    public Bitmap image;

    public Form1()
    {
        InitializeComponent();

        var rgbToHsvConverter = new RgbToHsvConverter();
        var rgbToYCbCrConverter = new RgbToYCbCrConverter();
        var rgbToLabConverter = new RgbToLabConverter(new SrgbToXYZConverter());

        var converters = new List<object>
        {
            rgbToHsvConverter,
            rgbToYCbCrConverter,
            rgbToLabConverter
        };

        converterComboBox.Items.AddRange(converters.ToArray());

        var srgbToXYZConverter = new SrgbToXYZConverter();
        var adobeRGBToXYZConverter = new AdobeRgbToXYZConverter();
        var wideGamutRGBToXYZConverter = new WideGamutToXYZConverter();

        var colorProfiles = new List<object>
        {
            srgbToXYZConverter,
            adobeRGBToXYZConverter,
            wideGamutRGBToXYZConverter,
            new CustomRgbToXyzConverter()
        };
        
        var predefinedIlluminants = new List<string>
        {
            "D50",
            "D65",
            "Custom"
        };

        colorProfileComboBox.Items.AddRange(colorProfiles.ToArray());
        predefinedIlluminantComboBox.Items.AddRange(predefinedIlluminants.ToArray());
    }

    private void loadImageButton_Click(object sender, EventArgs e)
    {
        var dialog = new OpenFileDialog();
        dialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
        dialog.Title = "Select an image file";
        dialog.Multiselect = false;
        dialog.CheckFileExists = true;
        dialog.CheckPathExists = true;
        dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            image = new Bitmap(dialog.FileName);

            pictureBox1.Image = image;
        }
    }

    private void SeparateChannels()
    {
        var colorModelConverter = (IColorModelConverter)converterComboBox.SelectedItem;

        if (colorModelConverter.GetType() == typeof(RgbToLabConverter))
        {
            var colorProfileConverter = (IRgbToXyzConverter)colorProfileComboBox.SelectedItem;
            if (colorProfileConverter.GetType() == typeof(CustomRgbToXyzConverter))
            {
                float xw, yw;
                switch (predefinedIlluminantComboBox.ToString())
                {
                    case "D50":
                        xw = 0.34567f;
                        yw = 0.35850f;
                        break;
                    case "D65":
                        xw = 0.31272f;
                        yw = 0.32903f;
                        break;
                    default:
                        xw = (float)xwNumericUpDown.Value;
                        yw = (float)ywNumericUpDown.Value;
                        break;
                }

                colorProfileConverter = new CustomRgbToXyzConverter(
                    (float)xRnumericUpDown.Value,
                    (float)yRnumericUpDown.Value,
                    (float)xGnumericUpDown.Value,
                    (float)yGnumericUpDown.Value,
                    (float)xBnumericUpDown.Value,
                    (float)yBnumericUpDown.Value,
                    xw,
                    yw,
                    (float)gammaNumericUpDown.Value
                );
            }

            colorModelConverter = new RgbToLabConverter(colorProfileConverter);
        }

        var extractor = new ImageExtractor(colorModelConverter);
        (b0, b1, b2) = extractor.Extract(image);

        b0PictureBox.Image = b0;
        b1PictureBox.Image = b1;
        b2PictureBox.Image = b2;
    }

    private void separateChannelsButton_Click(object sender, EventArgs e)
    {
        SeparateChannels();
    }
}