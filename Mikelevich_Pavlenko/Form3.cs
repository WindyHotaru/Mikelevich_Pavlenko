﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Глав = new Form1();
            Form3 ПР_16 = new Form3();
            ПР_16.FormClosed += formClosed;
            this.Hide();
            Глав.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        int h1 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            switch (rnd.Next(0, 5))
            {
                case 0:
                    Button bt = new Button();
                    bt.Width = rnd.Next(70, 300);
                    bt.Text = "Button";
                    bt.Location = new Point(10, 20 + 40 * h1);
                    bt.Visible = true;
                    Controls.Add(bt);
                    break;
                case 1:
                    Label lb = new Label();
                    lb.AutoSize = false;
                    lb.Width = rnd.Next(70, 300);
                    lb.BorderStyle = BorderStyle.FixedSingle;
                    lb.Text = "Label";
                    lb.Location = new Point(10, 20 + 40 * h1);
                    lb.Visible = true;
                    Controls.Add(lb);
                    break;
                case 2:
                    TextBox tb = new TextBox();
                    tb.Width = rnd.Next(70, 300);
                    tb.Text = "TextBox";
                    tb.Location = new Point(10, 20 + 40 * h1);
                    tb.Visible = true;
                    Controls.Add(tb);
                    break;
                case 3:
                    ComboBox cb = new ComboBox();
                    cb.Width = rnd.Next(70, 300);
                    cb.Text = "ComboBox";
                    cb.Location = new Point(10, 20 + 40 * h1);
                    cb.Visible = true;
                    Controls.Add(cb);
                    break;
                case 4:
                    NumericUpDown nd = new NumericUpDown();
                    nd.Width = rnd.Next(70, 300);
                    nd.Text = "NumericUpDown";
                    nd.Location = new Point(10, 20 + 40 * h1);
                    nd.Visible = true;
                    Controls.Add(nd);
                    break;
            }
            h1 += 1;
        }


    }
}
