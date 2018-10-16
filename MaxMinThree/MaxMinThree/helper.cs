using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinThree
{
    class helper
    {
        public int maxno(int n1,int n2,int n3)
        {
            int mx = 0;
            if(n1 > n2 && n1 > n3)
            {
                mx = n1;
            }
            else if(n2 > n1 && n2 > n3)
            {
                mx = n2;
            }
            else
            {
                mx = n3;
            }

            return mx;
        }

        public int minno(int n1,int n2,int n3)
        {
            int mn = 0;
            if (n1 < n2 && n1 < n3)
            {
                mn = n1;
            }
            else if (n2 < n1 && n2 < n3)
            {
                mn = n2;
            }
            else
            {
                mn = n3;
            }

            return mn;
        }

    }
}
