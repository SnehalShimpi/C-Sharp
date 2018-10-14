using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9._1
{
    class Marvellous
    {
        int iStart = 0;
        int iEnd = 0;
        public Marvellous(int start,int end)
        {
            this.iStart = start;
            this.iEnd = end;
        }
        public void DisplayRange()
        {
            int i = 0;
            for (i = iStart; i <= iEnd; i++)
                Console.WriteLine("{0}\t", i);
        }
    }
}
