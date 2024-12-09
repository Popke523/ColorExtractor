namespace ColorExtractor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            b2Label = new Label();
            b1Label = new Label();
            b0Label = new Label();
            b0PictureBox = new PictureBox();
            b1PictureBox = new PictureBox();
            b2PictureBox = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            loadImageButton = new Button();
            converterComboBox = new ComboBox();
            separateChannelsButton = new Button();
            saveOutputButton = new Button();
            createButton = new Button();
            groupBox1 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            predefinedIlluminantComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            colorProfileComboBox = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            yBnumericUpDown = new NumericUpDown();
            xBnumericUpDown = new NumericUpDown();
            yGnumericUpDown = new NumericUpDown();
            xGnumericUpDown = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            xRnumericUpDown = new NumericUpDown();
            yRnumericUpDown = new NumericUpDown();
            xwNumericUpDown = new NumericUpDown();
            label14 = new Label();
            ywNumericUpDown = new NumericUpDown();
            gammaNumericUpDown = new NumericUpDown();
            label15 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            comboBox4 = new ComboBox();
            label6 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            comboBox5 = new ComboBox();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)b0PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)b1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)b2PictureBox).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yBnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xBnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yGnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xGnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xRnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yRnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xwNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ywNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gammaNumericUpDown).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.4901047F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.5098953F));
            tableLayoutPanel1.Size = new Size(1240, 657);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(b2Label, 2, 0);
            tableLayoutPanel2.Controls.Add(b1Label, 1, 0);
            tableLayoutPanel2.Controls.Add(b0Label, 0, 0);
            tableLayoutPanel2.Controls.Add(b0PictureBox, 0, 1);
            tableLayoutPanel2.Controls.Add(b1PictureBox, 1, 1);
            tableLayoutPanel2.Controls.Add(b2PictureBox, 2, 1);
            tableLayoutPanel2.Location = new Point(3, 361);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1234, 293);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // b2Label
            // 
            b2Label.AutoSize = true;
            b2Label.Font = new Font("Segoe UI", 12F);
            b2Label.Location = new Point(825, 0);
            b2Label.Name = "b2Label";
            b2Label.Size = new Size(57, 21);
            b2Label.TabIndex = 2;
            b2Label.Text = "Cr/V/b";
            // 
            // b1Label
            // 
            b1Label.AutoSize = true;
            b1Label.Font = new Font("Segoe UI", 12F);
            b1Label.Location = new Point(414, 0);
            b1Label.Name = "b1Label";
            b1Label.Size = new Size(58, 21);
            b1Label.TabIndex = 1;
            b1Label.Text = "Cb/S/a";
            // 
            // b0Label
            // 
            b0Label.AutoSize = true;
            b0Label.Font = new Font("Segoe UI", 12F);
            b0Label.Location = new Point(3, 0);
            b0Label.Name = "b0Label";
            b0Label.Size = new Size(50, 21);
            b0Label.TabIndex = 0;
            b0Label.Text = "Y/H/L";
            // 
            // b0PictureBox
            // 
            b0PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b0PictureBox.Location = new Point(3, 24);
            b0PictureBox.Name = "b0PictureBox";
            b0PictureBox.Size = new Size(405, 266);
            b0PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            b0PictureBox.TabIndex = 3;
            b0PictureBox.TabStop = false;
            // 
            // b1PictureBox
            // 
            b1PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b1PictureBox.Location = new Point(414, 24);
            b1PictureBox.Name = "b1PictureBox";
            b1PictureBox.Size = new Size(405, 266);
            b1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            b1PictureBox.TabIndex = 4;
            b1PictureBox.TabStop = false;
            // 
            // b2PictureBox
            // 
            b2PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b2PictureBox.Location = new Point(825, 24);
            b2PictureBox.Name = "b2PictureBox";
            b2PictureBox.Size = new Size(406, 266);
            b2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            b2PictureBox.TabIndex = 5;
            b2PictureBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1234, 352);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(611, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(loadImageButton);
            flowLayoutPanel1.Controls.Add(converterComboBox);
            flowLayoutPanel1.Controls.Add(separateChannelsButton);
            flowLayoutPanel1.Controls.Add(saveOutputButton);
            flowLayoutPanel1.Controls.Add(createButton);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(620, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(611, 346);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.TabStop = true;
            // 
            // loadImageButton
            // 
            loadImageButton.Location = new Point(3, 3);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(121, 23);
            loadImageButton.TabIndex = 1;
            loadImageButton.Text = "Load Image";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // converterComboBox
            // 
            converterComboBox.FormattingEnabled = true;
            converterComboBox.Location = new Point(3, 32);
            converterComboBox.Name = "converterComboBox";
            converterComboBox.Size = new Size(121, 23);
            converterComboBox.TabIndex = 2;
            // 
            // separateChannelsButton
            // 
            separateChannelsButton.Location = new Point(3, 61);
            separateChannelsButton.Name = "separateChannelsButton";
            separateChannelsButton.Size = new Size(121, 23);
            separateChannelsButton.TabIndex = 3;
            separateChannelsButton.Text = "Separate Channels";
            separateChannelsButton.UseVisualStyleBackColor = true;
            separateChannelsButton.Click += separateChannelsButton_Click;
            // 
            // saveOutputButton
            // 
            saveOutputButton.Location = new Point(3, 90);
            saveOutputButton.Name = "saveOutputButton";
            saveOutputButton.Size = new Size(121, 23);
            saveOutputButton.TabIndex = 5;
            saveOutputButton.Text = "Save Output";
            saveOutputButton.UseVisualStyleBackColor = true;
            saveOutputButton.Click += saveOutputButton_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(3, 119);
            createButton.Name = "createButton";
            createButton.Size = new Size(121, 23);
            createButton.TabIndex = 6;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Location = new Point(130, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 287);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lab Settings";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(tableLayoutPanel4);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel7);
            flowLayoutPanel2.Location = new Point(6, 20);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(469, 262);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(predefinedIlluminantComboBox, 1, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Controls.Add(colorProfileComboBox, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(274, 58);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // predefinedIlluminantComboBox
            // 
            predefinedIlluminantComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            predefinedIlluminantComboBox.FormattingEnabled = true;
            predefinedIlluminantComboBox.Location = new Point(140, 32);
            predefinedIlluminantComboBox.Name = "predefinedIlluminantComboBox";
            predefinedIlluminantComboBox.Size = new Size(131, 23);
            predefinedIlluminantComboBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 0;
            label4.Text = "Predefined color profile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 29);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 1;
            label5.Text = "Predefined illuminant";
            // 
            // colorProfileComboBox
            // 
            colorProfileComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            colorProfileComboBox.FormattingEnabled = true;
            colorProfileComboBox.Location = new Point(140, 3);
            colorProfileComboBox.Name = "colorProfileComboBox";
            colorProfileComboBox.Size = new Size(131, 23);
            colorProfileComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.AutoSize = true;
            tableLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel7.Controls.Add(yBnumericUpDown, 2, 3);
            tableLayoutPanel7.Controls.Add(xBnumericUpDown, 1, 3);
            tableLayoutPanel7.Controls.Add(yGnumericUpDown, 2, 2);
            tableLayoutPanel7.Controls.Add(xGnumericUpDown, 1, 2);
            tableLayoutPanel7.Controls.Add(label8, 0, 0);
            tableLayoutPanel7.Controls.Add(label9, 1, 0);
            tableLayoutPanel7.Controls.Add(label10, 2, 0);
            tableLayoutPanel7.Controls.Add(label11, 0, 1);
            tableLayoutPanel7.Controls.Add(label12, 0, 2);
            tableLayoutPanel7.Controls.Add(label13, 0, 3);
            tableLayoutPanel7.Controls.Add(xRnumericUpDown, 1, 1);
            tableLayoutPanel7.Controls.Add(yRnumericUpDown, 2, 1);
            tableLayoutPanel7.Controls.Add(xwNumericUpDown, 1, 4);
            tableLayoutPanel7.Controls.Add(label14, 1, 5);
            tableLayoutPanel7.Controls.Add(ywNumericUpDown, 2, 4);
            tableLayoutPanel7.Controls.Add(gammaNumericUpDown, 2, 5);
            tableLayoutPanel7.Controls.Add(label15, 0, 4);
            tableLayoutPanel7.Location = new Point(3, 67);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 6;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.Size = new Size(363, 160);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // yBnumericUpDown
            // 
            yBnumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yBnumericUpDown.DecimalPlaces = 5;
            yBnumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
            yBnumericUpDown.Location = new Point(244, 76);
            yBnumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            yBnumericUpDown.Name = "yBnumericUpDown";
            yBnumericUpDown.Size = new Size(116, 23);
            yBnumericUpDown.TabIndex = 13;
            // 
            // xBnumericUpDown
            // 
            xBnumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xBnumericUpDown.DecimalPlaces = 5;
            xBnumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
            xBnumericUpDown.Location = new Point(123, 76);
            xBnumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            xBnumericUpDown.Name = "xBnumericUpDown";
            xBnumericUpDown.Size = new Size(115, 23);
            xBnumericUpDown.TabIndex = 12;
            // 
            // yGnumericUpDown
            // 
            yGnumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yGnumericUpDown.DecimalPlaces = 5;
            yGnumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
            yGnumericUpDown.Location = new Point(244, 47);
            yGnumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            yGnumericUpDown.Name = "yGnumericUpDown";
            yGnumericUpDown.Size = new Size(116, 23);
            yGnumericUpDown.TabIndex = 11;
            // 
            // xGnumericUpDown
            // 
            xGnumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xGnumericUpDown.DecimalPlaces = 5;
            xGnumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
            xGnumericUpDown.Location = new Point(123, 47);
            xGnumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            xGnumericUpDown.Name = "xGnumericUpDown";
            xGnumericUpDown.Size = new Size(115, 23);
            xGnumericUpDown.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 1;
            label8.Text = "Chromaticity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(123, 0);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 2;
            label9.Text = "x";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(244, 0);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 3;
            label10.Text = "y";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 15);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 4;
            label11.Text = "Red primary";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 44);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 5;
            label12.Text = "Green primary";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 73);
            label13.Name = "label13";
            label13.Size = new Size(74, 15);
            label13.TabIndex = 6;
            label13.Text = "Blue primary";
            // 
            // xRnumericUpDown
            // 
            xRnumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xRnumericUpDown.DecimalPlaces = 5;
            xRnumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
            xRnumericUpDown.Location = new Point(123, 18);
            xRnumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            xRnumericUpDown.Name = "xRnumericUpDown";
            xRnumericUpDown.Size = new Size(115, 23);
            xRnumericUpDown.TabIndex = 8;
            // 
            // yRnumericUpDown
            // 
            yRnumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yRnumericUpDown.DecimalPlaces = 5;
            yRnumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
            yRnumericUpDown.Location = new Point(244, 18);
            yRnumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            yRnumericUpDown.Name = "yRnumericUpDown";
            yRnumericUpDown.Size = new Size(116, 23);
            yRnumericUpDown.TabIndex = 9;
            // 
            // xwNumericUpDown
            // 
            xwNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xwNumericUpDown.DecimalPlaces = 5;
            xwNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
            xwNumericUpDown.Location = new Point(123, 105);
            xwNumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            xwNumericUpDown.Name = "xwNumericUpDown";
            xwNumericUpDown.Size = new Size(115, 23);
            xwNumericUpDown.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(123, 131);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 7;
            label14.Text = "Gamma";
            // 
            // ywNumericUpDown
            // 
            ywNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ywNumericUpDown.DecimalPlaces = 5;
            ywNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
            ywNumericUpDown.Location = new Point(244, 105);
            ywNumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            ywNumericUpDown.Name = "ywNumericUpDown";
            ywNumericUpDown.Size = new Size(116, 23);
            ywNumericUpDown.TabIndex = 15;
            // 
            // gammaNumericUpDown
            // 
            gammaNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gammaNumericUpDown.DecimalPlaces = 2;
            gammaNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            gammaNumericUpDown.Location = new Point(244, 134);
            gammaNumericUpDown.Name = "gammaNumericUpDown";
            gammaNumericUpDown.Size = new Size(116, 23);
            gammaNumericUpDown.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 102);
            label15.Name = "label15";
            label15.Size = new Size(69, 15);
            label15.TabIndex = 17;
            label15.Text = "White point";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(comboBox4, 1, 1);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(103, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(94, 23);
            comboBox4.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "label6";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(comboBox5, 1, 1);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(103, 23);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(94, 23);
            comboBox5.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 0;
            label7.Text = "label7";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)b0PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)b1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)b2PictureBox).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yBnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xBnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yGnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xGnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xRnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yRnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xwNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ywNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)gammaNumericUpDown).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown ywNumericUpDown;
        private System.Windows.Forms.NumericUpDown xwNumericUpDown;
        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.PictureBox b0PictureBox;
        private System.Windows.Forms.PictureBox b1PictureBox;
        private System.Windows.Forms.PictureBox b2PictureBox;

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button loadImageButton;
        private Label b2Label;
        private Label b1Label;
        private Label b0Label;
        private System.Windows.Forms.ComboBox converterComboBox;
        private System.Windows.Forms.Button separateChannelsButton;
        private GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox predefinedIlluminantComboBox;
        private Label label4;
        private Label label5;
        private ComboBox colorProfileComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label8;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox comboBox4;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel6;
        private ComboBox comboBox5;
        private Label label7;
        private System.Windows.Forms.NumericUpDown yBnumericUpDown;
        private System.Windows.Forms.NumericUpDown xBnumericUpDown;
        private System.Windows.Forms.NumericUpDown yGnumericUpDown;
        private System.Windows.Forms.NumericUpDown xGnumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown xRnumericUpDown;
        private System.Windows.Forms.NumericUpDown yRnumericUpDown;
        private System.Windows.Forms.NumericUpDown gammaNumericUpDown;
        private System.Windows.Forms.Button saveOutputButton;
        private Button createButton;
    }
}
