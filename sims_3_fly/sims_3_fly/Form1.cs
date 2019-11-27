using sims_3_fly_model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_3_fly
{
    public partial class Form1 : Form
    {
        Shell myShell;
        public Form1()
        {
            InitializeComponent();
            //myShell = new Shell(input_height.Value, input_angle.Value, input_speed.Value, input_size.Value, input_weight.Value);
        }

        //decimal y0 = 0;
        //decimal angle = 45;
        //decimal v = 10;
        //decimal t = 0;
        //decimal cosa, sina;
        //decimal x, y, vx, vy, k;
        //decimal m = 1;

        //decimal S = 0.1M;
        //const decimal dt = 0.01M;
        //const decimal g = 9.81M;

        private void timer1_Tick(object sender, EventArgs e)
        {
            myShell.fly();
            chart1.Series[0].Points.AddXY(myShell.x, myShell.y);
            if (myShell.y <= 0)
                timer1.Stop();
            Application.DoEvents();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                //y0 = input_height.Value;
                ////angle = input_angle.Value;
                //v = input_speed.Value;
                //S = input_size.Value;
                //m = input_weight.Value;
                //t = 0;
                //cosa = (decimal)Math.Cos((double)angle * Math.PI / 180);
                //sina = (decimal)Math.Sin((double)angle * Math.PI / 180);
                //vx = v * cosa;
                //vy = v * sina;
                //k = 0.075M * 1.29M * S / m;
                //x = 0; y = y0;
                myShell = new Shell(input_height.Value, input_angle.Value, input_speed.Value, input_size.Value, input_weight.Value);
                myShell.start_points();

                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.AddXY(myShell.x, myShell.y);
                timer1.Start();
            }
        }
    }

}






