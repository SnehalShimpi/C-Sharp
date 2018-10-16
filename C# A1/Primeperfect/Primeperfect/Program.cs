using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeperfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 0;
            bool iPrime, iPerfect;
            Console.Write("Enter Number : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            Prime pr = new Prime();
            Perfect pf = new Perfect();

            iPrime = pr.prime(iNo);
            iPerfect = pf.perfect(iNo);

            if(iPerfect == true)
            {
                Console.WriteLine(iNo + " Is a perfect Number.");
            }
            else
            {
                Console.WriteLine(iNo + " Is not a perfect Number.");
            }

            if(iPrime == true)
            {
                Console.WriteLine(iNo + " Is a Prime Number.");
            }
            else
            {
                Console.WriteLine(iNo + " Is not a Prime Number.");
            }

        }
    }
}
