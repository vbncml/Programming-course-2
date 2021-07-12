using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double k = 2;
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            k++;
            Label b = (Label)sender;
            if (k == 11)
            {
                MessageBox.Show("NO ONE WINNED");
                Application.Restart();
                    
            }else
            if (k % 2 != 0)
            {
                b.Text = "X";
            }
            else if (k % 2 == 0) { b.Text = "0"; }

            if (label1.Text=="X" && label1.Text == label3.Text && label3.Text == label2.Text)
                
            {
                MessageBox.Show("win X !!!");
                Application.Restart();
            }else
            if (label6.Text == "X" && label6.Text == label5.Text && label5.Text == label4.Text)
            {
                MessageBox.Show("win X !!!");
                Application.Restart();
            }else
            if (label9.Text == "X" && label9.Text == label8.Text && label8.Text == label7.Text)
            {
                MessageBox.Show("win X !!!");
                Application.Restart();
            }else
            if (label1.Text == "X" && label1.Text == label6.Text && label6.Text == label9.Text)
            {
                MessageBox.Show("win X !!!");
                Application.Restart();
            }else
            if (label3.Text == "X" && label3.Text == label5.Text && label5.Text == label8.Text)
            {
                MessageBox.Show("win X !!!");
                Application.Restart();
            }else
            if (label2.Text == "X" && label2.Text == label4.Text && label4.Text == label7.Text)
            {
                MessageBox.Show("win X !!!");
                Application.Restart();
            }else
            if (label1.Text == "X" && label1.Text == label5.Text && label5.Text == label7.Text)
            {
                MessageBox.Show("win X !!!");
                Application.Restart();
            }else
            if (label9.Text == "X" && label9.Text == label5.Text && label5.Text == label2.Text)
            {
                MessageBox.Show("win X !!!");
                Application.Restart();
            }else
            
            if (label1.Text=="0" && label1.Text == label3.Text && label3.Text == label2.Text)
                
            {
                MessageBox.Show("win 0 !!!");
                Application.Restart();
            }else
            if (label6.Text == "0" && label6.Text == label5.Text && label5.Text == label4.Text)
            {
                MessageBox.Show("win 0 !!!");
                Application.Restart();
            }else
            if (label9.Text == "0" && label9.Text == label8.Text && label8.Text == label7.Text)
            {
                MessageBox.Show("win 0 !!!");
                Application.Restart();
            }else
            if (label1.Text == "0" && label1.Text == label6.Text && label6.Text == label9.Text)
            {
                MessageBox.Show("win 0 !!!");
                Application.Restart();
            }else
            if (label3.Text == "0" && label3.Text == label5.Text && label5.Text == label8.Text)
            {
                MessageBox.Show("win 0 !!!");
                Application.Restart();
            }else
            if (label2.Text == "0" && label2.Text == label4.Text && label4.Text == label7.Text)
            {
                MessageBox.Show("win 0!!!");
                Application.Restart();
            }else
            if (label1.Text == "0" && label1.Text == label5.Text && label5.Text == label7.Text)
            {
                MessageBox.Show("win 0 !!!");
                Application.Restart();
            }else
                if (label9.Text == "0" && label9.Text == label5.Text && label5.Text == label2.Text)
                {
                    MessageBox.Show("win 0 !!!");
                    Application.Restart();
                }
               
        }
        
 
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
