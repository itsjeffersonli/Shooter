using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shooter
{
    class asteriod
    {
        int y1, y2;
        int x1, x2;
     int x = (x1+x2)/2;
     int y = (y1+y2)/2;
     g.drawLine(x1, y, x, y1);
     g.drawLine(x, y1, x2, y);
     g.drawLine(x2, y, x, y2);
     g.drawLine(x, y2, x1, y);
    }
}
