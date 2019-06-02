using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTP
{
    class Dot
    {
        public int i, j, x, y;
        public int State, Time, no, kol;
        public string koll;
        public Dot(int i, int j, int x, int y)
        {
            this.i = i;
            this.j = j;
            this.x = x;
            this.y = y;
            this.State = 2;
            this.Time = 0;
            this.no = 0;
            this.kol = 0;
        }
        public List<Dot> Near = new List<Dot>();
        public Dot(List<Dot> Dot)
        {
            this.Near = Dot;
        }
    }    
}
