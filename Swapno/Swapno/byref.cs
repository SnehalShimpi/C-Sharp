using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapno
{
    class byref
    {
        public static void SwapByRef(ref int no1,ref int no2)
        {
            int temp;
            temp = no1;
            no1 = no2;
            no2 = temp;

        }
    }
}
