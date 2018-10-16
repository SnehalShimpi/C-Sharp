using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeperfect
{
    class Perfect
    {
        public bool perfect(int no)
        {
            int i = 0, sum = 0, rem = 0;
            for (i = 1; i <= (no - 1); i++)
            {
                rem = no % i;
                if (rem == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == no)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
