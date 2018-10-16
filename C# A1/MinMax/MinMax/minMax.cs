using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class minMax
    {
        public int min(int[] brr, int no)
        {
            int i = 0;
            int imin = brr[0];
            
            for(i = 0;i < no; i++)
            {
                if (imin > brr[i])
                {
                    imin = brr[i];
                }
            }

            return imin;
        }

        public int max(int[] crr, int no)
        {
            int i = 0;
            int imax = 0;

            for(i = 0;i < no; i++)
            {
                if(imax < crr[i])
                {
                    imax = crr[i];
                }

            }
            return imax;
        }
    }
}
