using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass9._2
{
    class Marvellous
    {
        int iStart = 0;
        int iEnd = 0;
        public Marvellous(int start, int end)
        {
            this.iStart = start;
            this.iEnd = end;
        }
        public void DisplayRangeF()
        {
            int i = 0;
            for (i = iStart; i <= iEnd; i++)
                Console.WriteLine("{0}\t", i);
        }
        public void DisplayRangeB()
        {
            int i = 0;
            for (i = iEnd; i <= iStart; i--)
                Console.WriteLine("{0}\t", i);
        }
    }
}
