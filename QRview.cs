using System.Drawing.Drawing2D;

namespace QRGenerator
{
    public partial class QRview : Form
    {

        public QRview()
        {
            setting = Setting.GetInstance();
            InitializeComponent();
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(toEncode_textBox.Text))
            {
                QRGenerator qRGenerator = new(toEncode_textBox.Text);

                pictureBox.Image = qRGenerator.GenerateQrCode();
                setting.measurmentToDisplay = ((int)(pictureBox.Image.Height * 0.2645833333)).ToString() + "mm";
                tabPage1.Invalidate();
                tabPage1.Update();
            }
            else
            {
                MessageBox.Show("Brak tekstu do zakodowania!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    using (FileStream fs = (FileStream)saveFileDialog.OpenFile())
                    {
                        pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    pictureBox.Image = null;
                    tabPage1.Invalidate();
                    tabPage1.Update();
                }
            }
            else
            {
                MessageBox.Show("Brak wygenerowanego QRkodu do zapisania!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void readIcon_button_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                iconName_textBox.Text = openFileDialog.FileName;
                setting.bitmap = new Bitmap(openFileDialog.FileName);
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            iconName_textBox.Text = "";
            setting.bitmap = null;
        }

        private void panel_lightColor_Click(object sender, EventArgs e)
        {
            colorDialog_lightColor.ShowDialog();
            setting.lightColor = colorDialog_lightColor.Color;
            panel_lightColor.BackColor = setting.lightColor;
        }

        private void panel_darkColor_Click(object sender, EventArgs e)
        {
            colorDialog_darkColor.ShowDialog();
            setting.darkColor = colorDialog_darkColor.Color;
            panel_darkColor.BackColor = setting.darkColor;
        }

        private void panel_iconBackground_Click(object sender, EventArgs e)
        {
            colorDialog_iconBackground.ShowDialog();
            setting.iconBackground = colorDialog_iconBackground.Color;
            panel_iconBackground.BackColor = setting.iconBackground;
        }

        private void scrollBar_pixelPerModule_ValueChanged(object sender, EventArgs e)
        {
            textBox_pixelPerModule.Text = scrollBar_pixelPerModule.Value.ToString();
            setting.pixelPerModule = scrollBar_pixelPerModule.Value;
        }

        private void scrollBar_iconSize_ValueChanged(object sender, EventArgs e)
        {
            textBox_iconSize.Text = scrollBar_iconSize.Value.ToString();
            setting.iconSize = scrollBar_iconSize.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            setting.drawQuietZones = !setting.drawQuietZones;
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox.Image != null)
            {
                int labelGap = 60;
                using (Pen p = new Pen(Color.Gray))
                {
                    p.EndCap = LineCap.ArrowAnchor;
                    e.Graphics.DrawLine(p, 10, 72 + 350 / 2 - labelGap / 2, 10, 72);

                    p.EndCap = LineCap.ArrowAnchor;
                    e.Graphics.DrawLine(p, 10, 72 + 350 / 2 + labelGap / 2, 10, 422);
                }
                verticalLabel.Visible = true;
                verticalLabel.Location = new Point(0, 72 + 350 / 2 - labelGap / 2);

                verticalLabel.Width = 20;
                verticalLabel.Height = labelGap;
                verticalLabel.ForeColor = Color.Black;

                verticalLabel.NewText = setting.measurmentToDisplay;
                verticalLabel.Invalidate();
            }
            else
            {
                verticalLabel.Visible = false;
            }

        }

        private void numericUpDown_iconBorderWidth_ValueChanged(object sender, EventArgs e)
        {
            setting.iconBorderWidth = (int)numericUpDown_iconBorderWidth.Value;
        }

        private void comboBox_ecc_SelectedIndexChanged(object sender, EventArgs e)
        {
            setting.eccLevel = comboBox_ecc.Text;
        }
    }

    class VerticalLabel : Label
    {
        public int RotateAngle { get; set; }
        public string NewText { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            Brush b = new SolidBrush(this.ForeColor);

            SizeF stringSize = e.Graphics.MeasureString(this.NewText, this.Font);

            float x = (this.Width - stringSize.Width) / 2;
            float y = (this.Height - stringSize.Height) / 2;

            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(this.RotateAngle);
            e.Graphics.TranslateTransform(-this.Width / 2, -this.Height / 2);

            e.Graphics.DrawString(this.NewText, this.Font, b, x, y);

            e.Graphics.ResetTransform();
            base.OnPaint(e);
        }
    }
}
