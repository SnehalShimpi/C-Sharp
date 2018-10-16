using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 0, iFact = 0;

            Console.Write("Enter the number : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            helper help = new helper();

            iFact = help.fact(iNo);

            Console.WriteLine("\nFactorial of "+iNo+" is "+iFact);
            
        }
    }
}
