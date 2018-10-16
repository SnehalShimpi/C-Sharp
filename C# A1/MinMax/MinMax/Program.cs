 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 10;
            int i = 0;
            Console.Write("Number Of elements : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new Int32[iNo];

            Console.WriteLine("\n Enter array Elmements : ");
            for(i = 0;i < iNo; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            minMax mm = new minMax();

            Console.WriteLine("Maximum Number is : " + mm.max(Arr,iNo));
            Console.WriteLine("Minimum Number is : " + mm.min(Arr, iNo));

        }
    }
}
