using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace KTP
{
    class Dot
    {
        public int i, j, x, y;
        public Dot(int i, int j, int x, int y)
        {
            this.i = i;
            this.j = j;
            this.x = x;
            this.y = y;
        }

            public List<Dot> Near = new List<Dot>();
        public Dot(List<Dot> Dot)
        {
            this.Near = Dot;
        }
    }
}
