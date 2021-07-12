using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        List<Label> l;
        
        int p = 0,q=0;
        public Form1()
        {
            InitializeComponent();
            l = new List<Label>();
            l.Add(label1);
            l.Add(label2);
            l.Add(label3);
            l.Add(label4);
            l.Add(label5);
            l.Add(label6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l[0].Location = new Point(l[0].Location.X-15, l[0].Location.Y);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l[0].Location = new Point(l[0].Location.X +15, l[0].Location.Y);
            
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p++;
            label7.Text = Convert.ToString(p);
        }

        int a = 1;

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        Random rr = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            check();
            move();
          

        }
        int x = 10;
        private void label6_Click(object sender, EventArgs e)
        {

        }
        int b = 0;
        void move()
        {
            if (a == 1)
                l[1].Location = new Point(l[1].Location.X - x -10, l[1].Location.Y -10);
            if (a == 2)
                l[1].Location = new Point(l[1].Location.X + x+10, l[1].Location.Y -10);
            if(a == 3)
                l[1].Location = new Point(l[1].Location.X - x-10, l[1].Location.Y +10);
            if(a == 4)
                l[1].Location = new Point(l[1].Location.X + x+10, l[1].Location.Y+10);

           
           
        }
        
        void check()
        {
            if (l[1].Location.Y < 28 && a == 2)
            {
                a = 4;
                x = rr.Next(5);
            }

            else if (l[1].Location.Y < 28 && a == 1)
            {
                a = 3;
                x = rr.Next(5);
            }

             else if (l[1].Location.X < 22)
            {
                 if(a==3) 
                 {
                     a = 4; x = rr.Next(5);
                 }
                 else
                 {
                     a = 2;  x = rr.Next(5);
                 }
                    
             }
                
             else if (l[1].Location.X > 296)
                if (a == 4)
                {
                    a = 3; x = rr.Next(5);
                }
                else
                {
                     a = 1; x = rr.Next(5);
                }
                   
            else if (l[1].Location.Y > 301 && (l[1].Location.X <= l[0].Location.X && l[1].Location.X+48 >= l[0].Location.X))
            {
                if (a == 3)
                {
                    a = 1; x = rr.Next(5);
                }
                   
                else
                {
                          a = 2;
                    x = rr.Next(5);
                }
                   
            }
            else if(l[1].Location.Y > 363 )
            {
                timer2.Enabled = false;
                MessageBox.Show("Game over");
            }
            
            
            
           
               

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
    }
}
