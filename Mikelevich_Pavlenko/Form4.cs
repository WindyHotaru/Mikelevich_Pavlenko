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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Глав = new Form1();
            Form4 ПР_17 = new Form4();
            ПР_17.FormClosed += formClosed;
            this.Hide();
            Глав.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
