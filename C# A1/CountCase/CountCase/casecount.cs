using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCase
{
    class casecount
    {
        public void count(string str)
        {
            int i = 0;
            int upper = 0;
            int lower = 0;
            char ch = '\0';
            //Console.Write(str.Length);
            
            for(i = 0;i < str.Length; i++)
            {
                ch = str[i];

                if((ch >= 'A') && (ch <= 'Z'))
                {
                    upper++;
                }
                else if ((ch >= 'a') && (ch <= 'z'))
                {
                    lower++;
                }
            }

            Console.WriteLine("Upper Case Letter is : " + upper);
            Console.WriteLine("Lower case Letter is : " + lower);
            
        }
    }
}
