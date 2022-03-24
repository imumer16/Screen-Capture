using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace screenshort
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            screen();
        }

  
        private void screen()
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                pictureBox1.Image = new Bitmap(bitmap);
                saveFileDialog1.ShowDialog();
                string path = saveFileDialog1.FileName;
                bitmap.Save(path, ImageFormat.Png);

            }

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.Control && e.KeyCode == Keys.W)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show(" Press Capture to take ScreenShort", " Help! ");
            }
        }


    }
}
