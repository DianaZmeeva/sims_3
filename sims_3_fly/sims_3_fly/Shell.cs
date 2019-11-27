using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims_3_fly_model
{
    class Shell
    {
        decimal y0 = 0;
        decimal angle = 45;
        decimal v = 10;
        decimal t = 0;
        decimal m = 1;
        decimal S = 0.1M;

        decimal cosa, sina;
        public decimal x, y, vx, vy, k;

        const decimal dt = 0.01M;
        const decimal g = 9.81M;

        public Shell(decimal H, decimal A, decimal V, decimal s, decimal M)
        {
            y0 = H;
            angle = A;
            v = V;
            S = s;
            m = M;
        }

        public void start_points()
        {
            t = 0;
            cosa = (decimal)Math.Cos((double)angle * Math.PI / 180);
            sina = (decimal)Math.Sin((double)angle * Math.PI / 180);
            vx = v * cosa;
            vy = v * sina;
            k = 0.075M * 1.29M * S / m;
            x = 0;
            y = y0;
        }

        public void fly()
        {
            t += dt;
            v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
        }
    }
}
