using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake2
{
    public partial class Form1 : Form
    {
        List<Label> arr = new List<Label>();
        
        Random r = new Random();
        int n = 0;
        int size = 25;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++ )
            {
                arr.Add(new Label());
                
                arr[i].Location = new Point(r.Next(200), r.Next(200));
                arr[i].Size = new Size(size, size);
                Controls.Add(arr[i]);
            }
            arr[1].Image = Properties.Resources._28;
            arr[0].Image = Properties.Resources.og;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Up":
                    if(n!=1)
                    n = 0;
                    break;
                case "Down":
                    if (n != 0)
                    n = 1;
                    break;
                case "Left":
                    if (n != 3)
                    n = 2;
                    break;
                case "Right":
                    if (n != 2)
                    n = 3;
                    break;
            }
        }

        int x = 3;
        int y = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == y && timer1.Interval > 30)
            {
                timer1.Interval -= 10;
                x *= 2;
            }
            stena_check();
            
            if (arr.Count > 2)
            {
                move_back();
            }

            switch(n)
            {
                case 0:
                    arr[1].Location =
                      new Point(arr[1].Location.X, arr[1].Location.Y - size);
                    break;
                case 1:
                    arr[1].Location =
                      new Point(arr[1].Location.X, arr[1].Location.Y + size);
                    break;
                case 2:
                    arr[1].Location =
                      new Point(arr[1].Location.X - size, arr[1].Location.Y);
                    break;
                case 3:
                    arr[1].Location =
                      new Point(arr[1].Location.X + size, arr[1].Location.Y);
                    break;
            }

            if (Math.Abs(arr[0].Location.X - arr[1].Location.X) < size
                && Math.Abs(arr[0].Location.Y - arr[1].Location.Y) < size)
            {
                arr[0].Location = new Point(r.Next(500), r.Next(500));
                newElement();
                y++;
            }

            eatself();
        }

        private void eatself()
        {
            for(int i = 2; i < arr.Count - 1; i++)
            {
                if (Math.Abs(arr[1].Location.X - arr[i].Location.X) < size
                    && Math.Abs(arr[1].Location.Y - arr[i].Location.Y) < size)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Game Over");
                    break;
                }
            }
        }

        private void newElement()
        {
            Label l = new Label(); 
            l.Image = Properties.Resources._27;
            l.Location = new Point(arr[1].Location.X, arr[1].Location.Y);
            l.Size = new Size(size, size);
            arr.Add(l);
            Controls.Add(arr[arr.Count-1]);
        }


        private void move_back()
        {
            for (int i = arr.Count - 1; i > 1; i--)
            {
                arr[i].Location = new Point(arr[i - 1].Location.X, arr[i - 1].Location.Y);
            }
        }
        private void stena_check()
        {
            if (arr[1].Location.X < 0)
            {
                arr[1].Location =
                      new Point(500, arr[1].Location.Y);
            }
            if (arr[1].Location.X > 500)
            {
                arr[1].Location =
                      new Point(0, arr[1].Location.Y);
            }
            if (arr[1].Location.Y < 0)
            {
                arr[1].Location =
                      new Point(arr[1].Location.X, 500);
            }
            if (arr[1].Location.Y > 500)
            {
                arr[1].SetBounds(arr[1].Location.X, 0, arr[1].Width, arr[1].Height);
            }
        }
    }
}
