using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Service
    {
        public int Action(int x, int y)
        {
            if (x < 0)
                return -1;

            if (y < 0) return -1;

            return x + y;
        }
    }
}
