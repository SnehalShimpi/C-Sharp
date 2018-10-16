using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class helper
    {
        public int ifact;
        public helper()
        {
            ifact = 1;
        }


        public int fact(int n)
        {
            while(n != 1)
            {
                ifact = ifact * n;
                n--;
            }

            return ifact;
        }
    }
}
