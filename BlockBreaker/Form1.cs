using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlockBreaker
{
    public partial class Form1 : Form
    {
        Point position = new Point(0,0);
        Point positionRaket = new Point(303,341);

        Boolean xYon=true,yYon=true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            top.Location = position;
            raket.Location = positionRaket;
            btnBasla.Visible = false;
            timer1.Start();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (position.X + 40 == this.Width)
            {
                xYon = false;
                
            }
            if (position.Y + 60 == this.Height)
            {
                timer1.Stop();
                MessageBox.Show("Oyunu Kybettiniz");

                yYon = false;
            }
            if (position.Y +20 == positionRaket.Y)
            {
                
                if ((position.X + 20 > positionRaket.X && position.X < (positionRaket.X + 20 + raket.Size.Width)))
                {
                    xYon = true;
                    yYon = false;
                }
            }

            if(xYon)
                position.X = position.X + 1;
            else
                position.X = position.X - 1;
            if(yYon)
                position.Y = position.Y + 1;
            else
                position.Y = position.Y - 1;

            if (position.X == 0)
                xYon = true;
            if (position.Y == 0)
                yYon = true;

            top.Location = position;

            
        }
    }
}
