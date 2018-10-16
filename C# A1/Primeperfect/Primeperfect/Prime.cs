using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeperfect
{
    class Prime
    {
        public bool prime(int iNo)
        {
            int i = 0;
            int ans = 0;

            if (iNo < 0)
            {
                iNo = -iNo;
            }
            for (i = 2; i <= (iNo / 2); i++)
            {
                if (iNo % i == 0)
                {
                    ans = 1;
                    break;
                }

            }
            if (ans == 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
