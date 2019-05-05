using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTP
{
    class Line
    {
        public int xS, yS;
        public int xF, yF;

        public Line(int xS, int yS, int xF, int yF)
        {
            this.xS = xS;
            this.yS = yS;
            this.xF = xF;
            this.yF = yF;
        }
    }
}
