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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(1000);
            Form2 f2 = new Form2();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
            
        }


 

 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if ( e.Control &&e.KeyCode == Keys.W)
            {
                this.Close();
            }
            if (e.KeyCode==Keys.F1)
            {
                MessageBox.Show(" Press Capture to take ScreenShort"," Help! ");
            }
        }
    }
}
