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
        bool tabPressed = false;

        public Form1()
        {
            InitializeComponent();
            rtbRawCodes.Focus();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Bitmap codes = new Bitmap(pbCodes.Width, 10000);
            Graphics graphics = Graphics.FromImage(codes);
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            writer.Options.Height = 70;

            int y = 10;
            int last = 2;
            foreach (string s in rtbRawCodes.Lines)
            {
                if (!String.IsNullOrWhiteSpace(s.Trim()))
                {
                    if (s.StartsWith("/"))
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        graphics.DrawString(s.Replace('/', ' '), new Font("Tahoma", 14), Brushes.Black, new Point(codes.Width / 3, y));

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
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Tab) btnGenerate_Click(null, null);
            return false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent textbox beeping
            if (e.KeyChar == '\t') e.Handled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            btnGenerate_Click(null, null);
        }
    }
}
