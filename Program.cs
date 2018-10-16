using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String ch;
            char ch1;
            int ret = 0;
            Console.WriteLine("Enter string");
            ch = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter A Single Charcter");
            ch1 = Convert.ToChar(Console.ReadLine());
            MarvellousString ob = new MarvellousString(ch);
            Console.WriteLine("--------------length of String is----------");
            ret=ob.strlenx();
            Console.WriteLine("{0}", ret);
            Console.WriteLine("--------------Count of Capital character is----------");
            ret=ob.CountCapital();
            Console.WriteLine("{0}", ret);
            Console.WriteLine("--------------Count of small character is----------");
            ret = ob.CountSmall();
            Console.WriteLine("{0}", ret);
            Console.WriteLine("--------------frequancy of  character is----------");
            ret = ob.Frequency(ch1);
            Console.WriteLine("{0}", ret);
            Console.WriteLine("--------------Count Vowels is----------");
            ret = ob.CountVowels();
            Console.WriteLine("{0}", ret);
            Console.WriteLine("--------------Count space  is----------");
            ret = ob.CountSpace();
            Console.WriteLine("{0}", ret);
            Console.WriteLine("--------------first Search  character is----------");
            ret = ob.SearchFirst(ch1);
            Console.WriteLine("{0}", ret);
            Console.WriteLine("--------------last Search  character is----------");
            ret = ob.SearchLast(ch1);
            Console.WriteLine("{0}", ret);
        }
    }
}
