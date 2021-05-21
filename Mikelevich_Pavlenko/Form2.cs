using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikelevich_Pavlenko
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
   
        private void button8_Click(object sender, EventArgs e)
        {
            Form1 Глав = new Form1();
            Form2 ПР_15 = new Form2();
            ПР_15.FormClosed += formClosed;
            this.Hide();
            Глав.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
                    button5.Enabled = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
                    button6.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }
    }
}
