using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double value = 0;
        bool p = false, m=false, u = false, d = false, cos = false, sin = false, tan = false, dar = false, tub = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (value != 0)
            {
                value += Convert.ToDouble(textBox1.Text);
            }
            else
            {
                value = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "";
            p = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (value != 0)
            {
                value += Convert.ToDouble(textBox1.Text);
            }
            else
            {
                value = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "";
            m = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (value != 0)
            {
                value += Convert.ToDouble(textBox1.Text);
            }
            else
            {
                value = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "";
            d = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (value != 0)
            {
                value += Convert.ToDouble(textBox1.Text);
            }
            else
            {
                value = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "";
            u = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (value != 0)
            {
                value += Convert.ToDouble(textBox1.Text);
            }
            else
            {
                value = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "";
            dar = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sin = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            cos = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tan = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tub = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            value = 0;
             p = false;
            m=false;
            u = false;
            d = false;
            cos = false;
            sin = false;
            tan = false;
            dar = false;
            tub = false;
            textBox1.Text = "";
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (p) 
            {
                textBox1.Text = Convert.ToString(value + Convert.ToDouble(textBox1.Text));
            }
            if (m)
            {
                textBox1.Text = Convert.ToString(value - Convert.ToDouble(textBox1.Text));
            }
            if (u)
            {
                textBox1.Text = Convert.ToString(value * Convert.ToDouble(textBox1.Text));
            }
            if (d)
            {
                textBox1.Text = Convert.ToString(value / Convert.ToDouble(textBox1.Text));
            }
            if (dar)
            {
                textBox1.Text = Convert.ToString(Math.Pow(value,Convert.ToDouble(textBox1.Text)));
            }
            if (sin)
            {
                textBox1.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(System.Math.PI / 180) * (Convert.ToDouble(textBox1.Text))));
            }
            if (cos)
            {

                textBox1.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(System.Math.PI / 180) * (Convert.ToDouble(textBox1.Text))));
            }
            if (tan)
            {

                textBox1.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(System.Math.PI / 180) * (Convert.ToDouble(textBox1.Text))));
            }
            if (tub)
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            }
            p = false;
            m = false;
            u = false;
            d = false;
            cos = false;
            sin = false;
            tan = false;
            dar = false;
            tub = false;
            
        }
    }
}
