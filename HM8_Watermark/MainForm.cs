using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace HM8_Watermark
{
    public partial class MainForm : Form
    {
        private Font selectedFont;
        private Color selectedColor;
        private Bitmap originalImage;

        public MainForm()
        {
            InitializeComponent();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            InitFontStyleControls();
            InitColorStyleControls();
            InitLocationControls();

            addWatermarkButton.Enabled = false;
            addWatermarkButton.Click += addWatermarkButton_Click;

            loadImageButton.Enabled = true;
            loadImageButton.Click += loadImageButton_Click;

            saveImageButton.Enabled = false;
            saveImageButton.Click += saveImageButton_Click;

            clearButton.Enabled = false;
            clearButton.Click += (s, e) => pictureBox.Image = new Bitmap(originalImage);
        }
        private void InitLocationControls()
        {
            xPositionNumericUpDown.Maximum = pictureBox.Width;
            yPositionNumericUpDown.Maximum = pictureBox.Height;
            rotateNumericUpDown.Maximum = 360;
        }

        private void InitColorStyleControls()
        {
            Random rnd = new Random();
            foreach (var numerics in colorGroupBox.Controls.OfType<NumericUpDown>())
            {
                numerics.Maximum = 255;
                numerics.Value = rnd.Next(0, 255);
            }

            selectedColor = Color.FromArgb((int)redNumericUpDown.Value, (int)greenNumericUpDown.Value, (int)blueNumericUpDown.Value);

            colorTextBox.ReadOnly = true;
            colorTextBox.BackColor = selectedColor;

            selectColorButton.Click += (s, e) =>
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorTextBox.BackColor = colorDialog.Color;
                    redNumericUpDown.Value = colorDialog.Color.R;
                    greenNumericUpDown.Value = colorDialog.Color.G;
                    blueNumericUpDown.Value = colorDialog.Color.B;
                }
            };
        }
        private void InitFontStyleControls()
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fontComboBox.Items.Add(font.Name);
            }
            fontComboBox.SelectedIndex = 0;
            fontComboBox.MaxDropDownItems = 10;
            fontComboBox.DropDownHeight = fontComboBox.ItemHeight * (fontComboBox.MaxDropDownItems + 1);

            fontSizeNumericUpDown.Value = 40;

            watermarkTextBox.Text = "YOUR WATERMARK";

            selectFontButton.Click += (s, e) =>
            {
                FontDialog fontDialog = new FontDialog();
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    fontComboBox.SelectedItem = fontDialog.Font.Name;
                    fontSizeNumericUpDown.Value = (decimal)fontDialog.Font.Size;
                }
            };
        }

        private void addWatermarkButton_Click(object sender, EventArgs e)
        {
            string watermarkText = watermarkTextBox.Text;
            Bitmap bitmap = new Bitmap(pictureBox.Image);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                selectedFont = new Font(fontComboBox.SelectedItem.ToString(), (float)fontSizeNumericUpDown.Value);
                selectedColor = colorTextBox.BackColor;

                Brush brush = new SolidBrush(selectedColor);

                float x = (float)(xPositionNumericUpDown.Value);
                float y = (float)(yPositionNumericUpDown.Value);
                float rotationAngle = (float)rotateNumericUpDown.Value;

                graphics.RotateTransform(rotationAngle);

                graphics.DrawString(watermarkText, selectedFont, brush, x, y);
            }
            pictureBox.Image = bitmap;

            clearButton.Enabled = true;
            saveImageButton.Enabled = true;
        }

        /// не могу найти в чем ошибка, дважды загружается диалоговое окно при срабатывании события
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.jpg;*.png;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);

                pictureBox.Image = new Bitmap(originalImage);
                xPositionNumericUpDown.Maximum = pictureBox.Image.Width;
                yPositionNumericUpDown.Maximum = pictureBox.Image.Height - fontSizeNumericUpDown.Value;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                addWatermarkButton.Enabled = true;
            }
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image|*.jpg;*.png;*.bmp|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                pictureBox.Image.Save(filePath);
            }
        }
    }
}