

namespace QRGenerator
{
    partial class QRview
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
            save_button = new Button();
            generate_button = new Button();
            pictureBox = new PictureBox();
            saveFileDialog = new SaveFileDialog();
            toEncode_textBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            remove_button = new Button();
            iconName_textBox = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            readicon_button = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            openFileDialog = new OpenFileDialog();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            verticalLabel = new VerticalLabel();
            tabPage2 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label7 = new Label();
            label4 = new Label();
            numericUpDown_iconBorderWidth = new NumericUpDown();
            comboBox_ecc = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            textBox_iconSize = new TextBox();
            textBox_pixelPerModule = new TextBox();
            scrollBar_iconSize = new HScrollBar();
            scrollBar_pixelPerModule = new HScrollBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            panel_lightColor = new Panel();
            label8 = new Label();
            panel_darkColor = new Panel();
            label10 = new Label();
            panel_iconBackground = new Panel();
            colorDialog_lightColor = new ColorDialog();
            colorDialog_darkColor = new ColorDialog();
            colorDialog_iconBackground = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_iconBorderWidth).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // save_button
            // 
            save_button.Location = new Point(265, 3);
            save_button.Name = "save_button";
            save_button.Size = new Size(125, 40);
            save_button.TabIndex = 0;
            save_button.Text = "Zapisz";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // generate_button
            // 
            generate_button.Location = new Point(134, 3);
            generate_button.Name = "generate_button";
            generate_button.Size = new Size(125, 40);
            generate_button.TabIndex = 1;
            generate_button.Text = "Generuj";
            generate_button.UseVisualStyleBackColor = true;
            generate_button.Click += generate_button_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(22, 72);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(350, 350);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "QRkod.png";
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Zapisz QRkod";
            // 
            // toEncode_textBox
            // 
            toEncode_textBox.Location = new Point(133, 6);
            toEncode_textBox.Name = "toEncode_textBox";
            toEncode_textBox.Size = new Size(257, 23);
            toEncode_textBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 2;
            label1.Text = "Tekst do  zakodowania";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(remove_button);
            panel1.Controls.Add(iconName_textBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(toEncode_textBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 63);
            panel1.TabIndex = 6;
            // 
            // remove_button
            // 
            remove_button.Location = new Point(344, 35);
            remove_button.Name = "remove_button";
            remove_button.Size = new Size(46, 23);
            remove_button.TabIndex = 7;
            remove_button.Text = "Usuń";
            remove_button.UseVisualStyleBackColor = true;
            remove_button.Click += remove_button_Click;
            // 
            // iconName_textBox
            // 
            iconName_textBox.Enabled = false;
            iconName_textBox.Location = new Point(133, 36);
            iconName_textBox.Name = "iconName_textBox";
            iconName_textBox.Size = new Size(205, 23);
            iconName_textBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 39);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 5;
            label2.Text = "Icona (opcjonalnie)";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 505);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 0);
            panel2.TabIndex = 7;
            // 
            // readicon_button
            // 
            readicon_button.Location = new Point(3, 3);
            readicon_button.Name = "readicon_button";
            readicon_button.Size = new Size(125, 40);
            readicon_button.TabIndex = 2;
            readicon_button.Text = "Wczytaj ikonę";
            readicon_button.UseVisualStyleBackColor = true;
            readicon_button.Click += readIcon_button_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(readicon_button);
            flowLayoutPanel1.Controls.Add(generate_button);
            flowLayoutPanel1.Controls.Add(save_button);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(3, 428);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(396, 46);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.WrapContents = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(410, 505);
            tabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(verticalLabel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(402, 477);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Generator";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Paint += tabPage1_Paint;
            // 
            // verticalLabel
            // 
            verticalLabel.Location = new Point(0, 0);
            verticalLabel.Name = "verticalLabel";
            verticalLabel.NewText = "0px";
            verticalLabel.RotateAngle = -90;
            verticalLabel.Size = new Size(100, 23);
            verticalLabel.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel4);
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(402, 477);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ustawienia";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 278);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel4.Size = new Size(402, 100);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(151, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Jasny brzeg wokół kodu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.2786064F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.7213936F));
            tableLayoutPanel3.Controls.Add(label7, 0, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(numericUpDown_iconBorderWidth, 1, 0);
            tableLayoutPanel3.Controls.Add(comboBox_ecc, 1, 1);
            tableLayoutPanel3.Location = new Point(0, 199);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(402, 65);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 8);
            label7.Name = "label7";
            label7.Size = new Size(167, 15);
            label7.TabIndex = 0;
            label7.Text = "Szerokość obramowania ikony";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 41);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 0;
            label4.Text = "Poziom odczytywalności";
            // 
            // numericUpDown_iconBorderWidth
            // 
            numericUpDown_iconBorderWidth.Anchor = AnchorStyles.Left;
            numericUpDown_iconBorderWidth.Location = new Point(181, 4);
            numericUpDown_iconBorderWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_iconBorderWidth.Name = "numericUpDown_iconBorderWidth";
            numericUpDown_iconBorderWidth.Size = new Size(120, 23);
            numericUpDown_iconBorderWidth.TabIndex = 10;
            numericUpDown_iconBorderWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_iconBorderWidth.ValueChanged += numericUpDown_iconBorderWidth_ValueChanged;
            // 
            // comboBox_ecc
            // 
            comboBox_ecc.Anchor = AnchorStyles.Left;
            comboBox_ecc.FormattingEnabled = true;
            comboBox_ecc.Items.AddRange(new object[] { "L (7%)", "M (15%)", "Q (25%)", "H (30%)" });
            comboBox_ecc.Location = new Point(181, 37);
            comboBox_ecc.Name = "comboBox_ecc";
            comboBox_ecc.Size = new Size(121, 23);
            comboBox_ecc.TabIndex = 12;
            comboBox_ecc.SelectedItem = "Q (25%)";
            comboBox_ecc.SelectedIndexChanged += comboBox_ecc_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.05064F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9493675F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox_iconSize, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox_pixelPerModule, 1, 0);
            tableLayoutPanel2.Controls.Add(scrollBar_iconSize, 2, 1);
            tableLayoutPanel2.Controls.Add(scrollBar_pixelPerModule, 2, 0);
            tableLayoutPanel2.Location = new Point(0, 102);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(402, 81);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 5);
            label5.Name = "label5";
            label5.Size = new Size(110, 30);
            label5.TabIndex = 0;
            label5.Text = "Wielkość segmentu w pikselach";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 53);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 0;
            label6.Text = "Wielkość ikony w %";
            // 
            // textBox_iconSize
            // 
            textBox_iconSize.Anchor = AnchorStyles.None;
            textBox_iconSize.Enabled = false;
            textBox_iconSize.Location = new Point(120, 49);
            textBox_iconSize.Name = "textBox_iconSize";
            textBox_iconSize.Size = new Size(35, 23);
            textBox_iconSize.TabIndex = 7;
            textBox_iconSize.Text = "15";
            textBox_iconSize.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_pixelPerModule
            // 
            textBox_pixelPerModule.Anchor = AnchorStyles.None;
            textBox_pixelPerModule.Enabled = false;
            textBox_pixelPerModule.Location = new Point(120, 8);
            textBox_pixelPerModule.Name = "textBox_pixelPerModule";
            textBox_pixelPerModule.Size = new Size(35, 23);
            textBox_pixelPerModule.TabIndex = 6;
            textBox_pixelPerModule.Text = "20";
            textBox_pixelPerModule.TextAlign = HorizontalAlignment.Center;
            // 
            // scrollBar_iconSize
            // 
            scrollBar_iconSize.Anchor = AnchorStyles.None;
            scrollBar_iconSize.Location = new Point(165, 53);
            scrollBar_iconSize.Maximum = 108;
            scrollBar_iconSize.Minimum = 1;
            scrollBar_iconSize.Name = "scrollBar_iconSize";
            scrollBar_iconSize.Size = new Size(230, 15);
            scrollBar_iconSize.TabIndex = 8;
            scrollBar_iconSize.Value = 15;
            scrollBar_iconSize.ValueChanged += scrollBar_iconSize_ValueChanged;
            // 
            // scrollBar_pixelPerModule
            // 
            scrollBar_pixelPerModule.Anchor = AnchorStyles.None;
            scrollBar_pixelPerModule.Location = new Point(165, 12);
            scrollBar_pixelPerModule.Maximum = 109;
            scrollBar_pixelPerModule.Minimum = 1;
            scrollBar_pixelPerModule.Name = "scrollBar_pixelPerModule";
            scrollBar_pixelPerModule.Size = new Size(230, 16);
            scrollBar_pixelPerModule.TabIndex = 5;
            scrollBar_pixelPerModule.Value = 20;
            scrollBar_pixelPerModule.ValueChanged += scrollBar_pixelPerModule_ValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.5124359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.4875641F));
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Controls.Add(panel_lightColor, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 1);
            tableLayoutPanel1.Controls.Add(panel_darkColor, 1, 1);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(panel_iconBackground, 1, 2);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(402, 80);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 5);
            label9.Name = "label9";
            label9.Size = new Size(143, 15);
            label9.TabIndex = 0;
            label9.Text = "Kolor jasnych segmentów";
            // 
            // panel_lightColor
            // 
            panel_lightColor.Anchor = AnchorStyles.Left;
            panel_lightColor.BackColor = Color.White;
            panel_lightColor.BorderStyle = BorderStyle.Fixed3D;
            panel_lightColor.Cursor = Cursors.Hand;
            panel_lightColor.Location = new Point(194, 3);
            panel_lightColor.Name = "panel_lightColor";
            panel_lightColor.Size = new Size(32, 20);
            panel_lightColor.TabIndex = 2;
            panel_lightColor.Click += panel_lightColor_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 31);
            label8.Name = "label8";
            label8.Size = new Size(155, 15);
            label8.TabIndex = 0;
            label8.Text = "Kolor ciemnych segmentów";
            // 
            // panel_darkColor
            // 
            panel_darkColor.Anchor = AnchorStyles.Left;
            panel_darkColor.BackColor = Color.Black;
            panel_darkColor.BorderStyle = BorderStyle.Fixed3D;
            panel_darkColor.Cursor = Cursors.Hand;
            panel_darkColor.Location = new Point(194, 29);
            panel_darkColor.Name = "panel_darkColor";
            panel_darkColor.Size = new Size(32, 20);
            panel_darkColor.TabIndex = 3;
            panel_darkColor.Click += panel_darkColor_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 58);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 0;
            label10.Text = "Kolor tła ikony";
            // 
            // panel_iconBackground
            // 
            panel_iconBackground.Anchor = AnchorStyles.Left;
            panel_iconBackground.BackColor = Color.Red;
            panel_iconBackground.BorderStyle = BorderStyle.Fixed3D;
            panel_iconBackground.Cursor = Cursors.Hand;
            panel_iconBackground.Location = new Point(194, 55);
            panel_iconBackground.Name = "panel_iconBackground";
            panel_iconBackground.Size = new Size(32, 22);
            panel_iconBackground.TabIndex = 4;
            panel_iconBackground.Click += panel_iconBackground_Click;
            // 
            // colorDialog_lightColor
            // 
            colorDialog_lightColor.Color = Color.White;
            // 
            // QRview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 505);
            Controls.Add(tabControl);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QRview";
            Text = "QRGenerator";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_iconBorderWidth).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_button;
        private Button generate_button;
        private PictureBox pictureBox;
        private SaveFileDialog saveFileDialog;
        private TextBox toEncode_textBox;
        private Label label1;
        private Panel panel1;
        private Button remove_button;
        private TextBox iconName_textBox;
        private Label label2;
        private Panel panel2;
        private Button readicon_button;
        private FlowLayoutPanel flowLayoutPanel1;
        private OpenFileDialog openFileDialog;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ColorDialog colorDialog_lightColor;
        private Panel panel_lightColor;
        private Panel panel_iconBackground;
        private Panel panel_darkColor;
        private ColorDialog colorDialog_darkColor;
        private ColorDialog colorDialog_iconBackground;
        private TextBox textBox_pixelPerModule;
        private HScrollBar scrollBar_pixelPerModule;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown_iconBorderWidth;
        private HScrollBar scrollBar_iconSize;
        private TextBox textBox_iconSize;
        private ComboBox comboBox_ecc;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private VerticalLabel verticalLabel;
        private Setting setting;
    }
}
