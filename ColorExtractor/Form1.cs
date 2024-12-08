namespace ColorExtractor
{
    public partial class Form1 : Form
    {
        public Bitmap image;
        public Bitmap b0;
        public Bitmap b1;
        public Bitmap b2;
        public IColorModelConverter ColorModelConverter { get; set; } = new RgbToYCbCrConverter();
        
        public Form1()
        {
            InitializeComponent();
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
                
                var extractor = new ImageExtractor(ColorModelConverter);
                (b0, b1, b2) = extractor.Extract(image);
                
                b0PictureBox.Image = b0;
                b1PictureBox.Image = b1;
                b2PictureBox.Image = b2;
            }
        }
    }
}
