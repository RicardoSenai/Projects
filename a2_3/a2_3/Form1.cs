using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;

            if (checkBox1.Checked == true) {
                while( Visible ){

                for (c = 0; c < 254; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(8);
                }
                for (c = 254; c > 0; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(8);
                }}
                    
            } else {
                label1.BackColor = Color.Yellow;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
