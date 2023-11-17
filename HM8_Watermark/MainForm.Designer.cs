namespace HM8_Watermark
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog = new ColorDialog();
            fontComboBox = new ComboBox();
            pictureBox = new PictureBox();
            watermarkTextBox = new TextBox();
            fontSizeNumericUpDown = new NumericUpDown();
            colorTextBox = new TextBox();
            loadImageButton = new Button();
            addWatermarkButton = new Button();
            selectFontButton = new Button();
            selectColorButton = new Button();
            splitContainer = new SplitContainer();
            locationGroupBox = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            rotateNumericUpDown = new NumericUpDown();
            yPositionNumericUpDown = new NumericUpDown();
            xPositionNumericUpDown = new NumericUpDown();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            colorGroupBox = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            blueNumericUpDown = new NumericUpDown();
            greenNumericUpDown = new NumericUpDown();
            redNumericUpDown = new NumericUpDown();
            fontStyleGroupBox = new GroupBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            clearButton = new Button();
            saveImageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            locationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rotateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yPositionNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xPositionNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            colorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blueNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redNumericUpDown).BeginInit();
            fontStyleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // fontComboBox
            // 
            fontComboBox.FormattingEnabled = true;
            fontComboBox.Location = new Point(5, 26);
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Size = new Size(151, 28);
            fontComboBox.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(520, 420);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // watermarkTextBox
            // 
            watermarkTextBox.Location = new Point(5, 93);
            watermarkTextBox.Name = "watermarkTextBox";
            watermarkTextBox.Size = new Size(151, 27);
            watermarkTextBox.TabIndex = 2;
            // 
            // fontSizeNumericUpDown
            // 
            fontSizeNumericUpDown.Location = new Point(5, 60);
            fontSizeNumericUpDown.Name = "fontSizeNumericUpDown";
            fontSizeNumericUpDown.Size = new Size(151, 27);
            fontSizeNumericUpDown.TabIndex = 3;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(5, 26);
            colorTextBox.Multiline = true;
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(250, 50);
            colorTextBox.TabIndex = 6;
            // 
            // loadImageButton
            // 
            loadImageButton.Location = new Point(3, 458);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(254, 40);
            loadImageButton.TabIndex = 7;
            loadImageButton.Text = "Load Image";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // addWatermarkButton
            // 
            addWatermarkButton.Location = new Point(3, 427);
            addWatermarkButton.Name = "addWatermarkButton";
            addWatermarkButton.Size = new Size(511, 29);
            addWatermarkButton.TabIndex = 8;
            addWatermarkButton.Text = "Add Watermark";
            addWatermarkButton.UseVisualStyleBackColor = true;
            addWatermarkButton.Click += addWatermarkButton_Click;
            // 
            // selectFontButton
            // 
            selectFontButton.Location = new Point(5, 126);
            selectFontButton.Name = "selectFontButton";
            selectFontButton.Size = new Size(250, 29);
            selectFontButton.TabIndex = 9;
            selectFontButton.Text = "Font Style Selection";
            selectFontButton.UseVisualStyleBackColor = true;
            // 
            // selectColorButton
            // 
            selectColorButton.Location = new Point(5, 181);
            selectColorButton.Name = "selectColorButton";
            selectColorButton.Size = new Size(250, 29);
            selectColorButton.TabIndex = 10;
            selectColorButton.Text = "Color Selection";
            selectColorButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            splitContainer.BorderStyle = BorderStyle.FixedSingle;
            splitContainer.Location = new Point(6, 7);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(locationGroupBox);
            splitContainer.Panel1.Controls.Add(colorGroupBox);
            splitContainer.Panel1.Controls.Add(fontStyleGroupBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(clearButton);
            splitContainer.Panel2.Controls.Add(saveImageButton);
            splitContainer.Panel2.Controls.Add(pictureBox);
            splitContainer.Panel2.Controls.Add(loadImageButton);
            splitContainer.Panel2.Controls.Add(addWatermarkButton);
            splitContainer.Size = new Size(789, 539);
            splitContainer.SplitterDistance = 263;
            splitContainer.TabIndex = 11;
            // 
            // locationGroupBox
            // 
            locationGroupBox.Controls.Add(label10);
            locationGroupBox.Controls.Add(label9);
            locationGroupBox.Controls.Add(label8);
            locationGroupBox.Controls.Add(rotateNumericUpDown);
            locationGroupBox.Controls.Add(yPositionNumericUpDown);
            locationGroupBox.Controls.Add(xPositionNumericUpDown);
            locationGroupBox.Controls.Add(label7);
            locationGroupBox.Controls.Add(numericUpDown1);
            locationGroupBox.Controls.Add(button1);
            locationGroupBox.Location = new Point(0, 389);
            locationGroupBox.Name = "locationGroupBox";
            locationGroupBox.Size = new Size(259, 140);
            locationGroupBox.TabIndex = 16;
            locationGroupBox.TabStop = false;
            locationGroupBox.Text = "WATERMARK LOCATION";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(162, 98);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 21;
            label10.Text = "Rotation";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(162, 65);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 20;
            label9.Text = "Y coordinate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(162, 32);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 19;
            label8.Text = "X coordinate";
            // 
            // rotateNumericUpDown
            // 
            rotateNumericUpDown.Location = new Point(6, 92);
            rotateNumericUpDown.Name = "rotateNumericUpDown";
            rotateNumericUpDown.Size = new Size(151, 27);
            rotateNumericUpDown.TabIndex = 18;
            // 
            // yPositionNumericUpDown
            // 
            yPositionNumericUpDown.Location = new Point(6, 59);
            yPositionNumericUpDown.Name = "yPositionNumericUpDown";
            yPositionNumericUpDown.Size = new Size(151, 27);
            yPositionNumericUpDown.TabIndex = 17;
            // 
            // xPositionNumericUpDown
            // 
            xPositionNumericUpDown.Location = new Point(6, 26);
            xPositionNumericUpDown.Name = "xPositionNumericUpDown";
            xPositionNumericUpDown.Size = new Size(151, 27);
            xPositionNumericUpDown.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(162, 153);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 15;
            label7.Text = "BLUE";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 148);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(151, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(5, 181);
            button1.Name = "button1";
            button1.Size = new Size(250, 29);
            button1.TabIndex = 10;
            button1.Text = "Color Selection";
            button1.UseVisualStyleBackColor = true;
            // 
            // colorGroupBox
            // 
            colorGroupBox.Controls.Add(label6);
            colorGroupBox.Controls.Add(label5);
            colorGroupBox.Controls.Add(label4);
            colorGroupBox.Controls.Add(blueNumericUpDown);
            colorGroupBox.Controls.Add(greenNumericUpDown);
            colorGroupBox.Controls.Add(redNumericUpDown);
            colorGroupBox.Controls.Add(colorTextBox);
            colorGroupBox.Controls.Add(selectColorButton);
            colorGroupBox.Location = new Point(0, 167);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Size = new Size(259, 216);
            colorGroupBox.TabIndex = 12;
            colorGroupBox.TabStop = false;
            colorGroupBox.Text = "WATERMARK COLOR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(162, 153);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 15;
            label6.Text = "BLUE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Green;
            label5.Location = new Point(162, 120);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 14;
            label5.Text = "GREEN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(162, 87);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 13;
            label4.Text = "RED";
            // 
            // blueNumericUpDown
            // 
            blueNumericUpDown.Location = new Point(6, 148);
            blueNumericUpDown.Name = "blueNumericUpDown";
            blueNumericUpDown.Size = new Size(151, 27);
            blueNumericUpDown.TabIndex = 12;
            // 
            // greenNumericUpDown
            // 
            greenNumericUpDown.Location = new Point(6, 115);
            greenNumericUpDown.Name = "greenNumericUpDown";
            greenNumericUpDown.Size = new Size(151, 27);
            greenNumericUpDown.TabIndex = 11;
            // 
            // redNumericUpDown
            // 
            redNumericUpDown.Location = new Point(6, 82);
            redNumericUpDown.Name = "redNumericUpDown";
            redNumericUpDown.Size = new Size(151, 27);
            redNumericUpDown.TabIndex = 10;
            // 
            // fontStyleGroupBox
            // 
            fontStyleGroupBox.Controls.Add(fontComboBox);
            fontStyleGroupBox.Controls.Add(selectFontButton);
            fontStyleGroupBox.Controls.Add(fontSizeNumericUpDown);
            fontStyleGroupBox.Controls.Add(watermarkTextBox);
            fontStyleGroupBox.Controls.Add(label1);
            fontStyleGroupBox.Controls.Add(label3);
            fontStyleGroupBox.Controls.Add(label2);
            fontStyleGroupBox.Location = new Point(0, 0);
            fontStyleGroupBox.Name = "fontStyleGroupBox";
            fontStyleGroupBox.Size = new Size(259, 161);
            fontStyleGroupBox.TabIndex = 11;
            fontStyleGroupBox.TabStop = false;
            fontStyleGroupBox.Text = "WATERMARK FONT STYLE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Font Style";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(162, 64);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Font Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(162, 97);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Watermark";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(3, 500);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(511, 29);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // saveImageButton
            // 
            saveImageButton.Location = new Point(260, 458);
            saveImageButton.Name = "saveImageButton";
            saveImageButton.Size = new Size(254, 40);
            saveImageButton.TabIndex = 11;
            saveImageButton.Text = "Save Image";
            saveImageButton.UseVisualStyleBackColor = true;
            saveImageButton.Click += saveImageButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(splitContainer);
            Name = "MainForm";
            Text = "Watermarks App";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumericUpDown).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            locationGroupBox.ResumeLayout(false);
            locationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rotateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yPositionNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xPositionNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            colorGroupBox.ResumeLayout(false);
            colorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)blueNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)redNumericUpDown).EndInit();
            fontStyleGroupBox.ResumeLayout(false);
            fontStyleGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog;
        private ComboBox fontComboBox;
        private PictureBox pictureBox;
        private TextBox watermarkTextBox;
        private NumericUpDown fontSizeNumericUpDown;
        private TextBox colorTextBox;
        private Button loadImageButton;
        private Button addWatermarkButton;
        private Button selectFontButton;
        private Button selectColorButton;
        private SplitContainer splitContainer;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button saveImageButton;
        private GroupBox fontStyleGroupBox;
        private GroupBox colorGroupBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown blueNumericUpDown;
        private NumericUpDown greenNumericUpDown;
        private NumericUpDown redNumericUpDown;
        private GroupBox locationGroupBox;
        private NumericUpDown rotateNumericUpDown;
        private NumericUpDown yPositionNumericUpDown;
        private NumericUpDown xPositionNumericUpDown;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label8;
        private Label label10;
        private Label label9;
        private Button clearButton;
    }
}