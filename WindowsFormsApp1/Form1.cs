using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Bitmap codes = new Bitmap(pbCodes.Width, 10000);
            Graphics graphics = Graphics.FromImage(codes);
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };

            int y = 10;
            int last = 2;
            foreach (string s in rtbRawCodes.Lines)
            {
                if (!String.IsNullOrWhiteSpace(s.Trim()))
                {
                    Bitmap code = writer.Write(s.Trim());
                    graphics.DrawImage(code, codes.Width / 2 - code.Width / 2, y);
                    y += code.Height + 30;
                    last = code.Height;
                } else
                {
                    y += last / 2;
                }
            }

            pbCodes.Image = codes;
        }
    }
}
