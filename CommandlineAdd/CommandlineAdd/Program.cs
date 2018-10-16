using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandlineAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 0, n = 0;
             for(i = 0;i < args.Length; i++)
            {
                n = Convert.ToInt32(args[i]);
                Console.Write(n + " + ");
                sum = sum + n;
            }

            Console.WriteLine("\nAddition is : " + sum);
        }
    }
}
