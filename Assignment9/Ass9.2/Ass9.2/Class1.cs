using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ass9._2
{
    class Class1
    {
       
            public void DisplayRangeF(int iStart ,int iEnd)
            {
            Thread t = Thread.CurrentThread;
                int i = 0;
            for (i = iStart; i <= iEnd; i++)
            {
                Console.WriteLine("{0}\t", i);
                Thread.Sleep(1000);
            }
        }
        public void DisplayRangeB(int iStart,int iEnd)
        {
            int i = 0;
            for (i = iEnd; i >= iStart; i--)
            {
                Console.WriteLine("{0}\t", i);
            }
        }

        }

    }


