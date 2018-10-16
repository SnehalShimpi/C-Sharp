using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDigit
{
    class helper
    {

        public static int cntdig(int no)
        {
            int cnt = 0;

            while(no != 0)
            {
                cnt++;
                no = no / 10;
            }

            return cnt;
        }
    }
}
