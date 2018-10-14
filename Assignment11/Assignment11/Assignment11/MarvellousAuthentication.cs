using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class MarvellousAuthentication
    {
        public string password;
   
     
        public MarvellousAuthentication(string str)
        {
            password = str;
        }
        public Boolean ChkPassword()
        {
            int icnt = 0;
            foreach (char ch in password)
            {
                icnt = icnt + 1;
            }
            //Console.WriteLine("{0}",icnt);
            
            int iCap = 0;
            foreach (char ch in password)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    iCap = iCap + 1;
                }
            }
            int ismall = 0;
            foreach (char ch in password)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    ismall = ismall+ 1;
                }
            }
            int idigit = 0;
            foreach (char ch in password)
            {
                if (ch >= '0' && ch <= '9')
                {
                    idigit = idigit + 1;
                }
            }
            if ((icnt >=7) || (iCap>=3) && (ismall>=2) || (idigit>=2))
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
