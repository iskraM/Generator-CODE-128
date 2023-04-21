using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Code128Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtbRawCodes.Focus();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int totalHeight = 0;
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            writer.Options.Height = 70;

            foreach (string s in rtbRawCodes.Lines)
            {
                if (!String.IsNullOrEmpty(s.Trim()))
                {
                    if (s.StartsWith("/"))
                    {
                        totalHeight += 30;
                    }
                    else
                    {
                        Bitmap code = writer.Write(s.Trim());
                        totalHeight += code.Height + 30;
                    }
                }
                else
                {
                    totalHeight += 15;
                }
            }

            // marging at bottom
            totalHeight += 40;

            if (totalHeight < panel1.Height - 6)
                totalHeight = panel1.Height - 6;

            Bitmap codes = new Bitmap(pbCodes.Width, totalHeight);
            Graphics graphics = Graphics.FromImage(codes);
            writer.Options.Height = 70;

            int y = 10;
            int last = 2;
            foreach (string s in rtbRawCodes.Lines)
            {
                if (!String.IsNullOrWhiteSpace(s.Trim()))
                {
                    if (s.StartsWith("/"))
                    {
                        int centerX = pbCodes.Width / 2;

                        // Calculate the location to draw the text
                        SizeF textSize = graphics.MeasureString(s.Replace('/', ' ').Trim(), new Font("Microsoft Sans Serif", 14));
                        Point textLocation = new Point(centerX - (int)(textSize.Width / 2) - 10, y);

                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        graphics.DrawString(s.Replace('/', ' '), new Font("Microsoft Sans Serif", 14), Brushes.Black, textLocation);

                        graphics.Flush();
                        y += 30;
                    }
                    else
                    {
                        Bitmap code = writer.Write(s.Trim());
                        graphics.DrawImage(code, codes.Width / 2 - code.Width / 2, y);
                        y += code.Height + 30;
                        last = code.Height;
                    }
                } else
                {
                    y += last / 2;
                }
            }

            pbCodes.Image = codes;
            pbCodes.Height = codes.Height;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Tab) btnGenerate_Click(null, null);
            return false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\t') e.Handled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            btnGenerate_Click(null, null);
        }
    }
}
