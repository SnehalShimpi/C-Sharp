using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    public  static class ArraySum
    {
        public static int SumArr(int[] brr,int no)
        {
            int i = 0, sum = 0;

            for(i = 0;i < no; i++)
            {
                sum = sum + brr[i];
            }

            return sum;
        }
    }
}
