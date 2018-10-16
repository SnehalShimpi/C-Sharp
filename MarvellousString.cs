using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class MarvellousString
    {
        public string str;
        public MarvellousString(string name)
        {
            str = name;
        }
        public int strlenx()
        {
            int icnt = 0;
            foreach(char ch in str)
            {
                icnt = icnt + 1;
            }
            //Console.WriteLine("{0}",icnt);
            return icnt;
        }
        
        public int CountCapital()
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (ch >= 'A' &&  ch <= 'Z')
                    {
                    icnt = icnt + 1;
                }
            }
            //Console.WriteLine("{0}", icnt);


            
            return icnt;
        }
        
        public int CountSmall()
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    icnt = icnt + 1;
                }
            }
            //Console.WriteLine("{0}", icnt);

            
            return icnt;
        }
        
        public int Frequency(char ch1)
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (ch ==ch1)
                {
                    icnt++;
                }
            }
            //Console.WriteLine("{0}", icnt);

            
            return icnt;
        }
        public int CountVowels()
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (( ch == 'a') &&( ch == 'e') && (ch == 'i') && (ch == 'o') &&( ch == 'u'))
                {
                    icnt ++;
                }
            }
            //Console.WriteLine("{0}", icnt);

            return icnt;
        }
        public int CountSpace()
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (ch == ' ')
                {
                    icnt  ++;
                }
            }
            //Console.WriteLine("{0}", icnt);

            
            return icnt;
        }
        public int SearchFirst(char ch1)
        {
            int i = 0;
            foreach (char ch in str)
            {
                i++;
                if (ch==ch1)
                {
                    break;
                }
               
            }

            //Console.WriteLine("{0}", i);
            return i;
        }
       
        public int SearchLast(char ch1)
        {
            int i = 0;
            int j = 0;
            
            foreach ( char ch in str)
            {
                
                i++;
                
            }
            for (j = i; j >= 0; j--)
            {
                foreach(char ch in str)
                if (ch == ch1)
                {
                    break;
                }

            }

            return j;            

        }
      /*  public boolean CheckPalindrome()
        {
            // Logic
        }
        */
    }

}
