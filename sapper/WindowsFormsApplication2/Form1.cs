using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Visible = false;
            if (b == button1 || b == button8 || b == button14) { MessageBox.Show("GAME OVER"); }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
