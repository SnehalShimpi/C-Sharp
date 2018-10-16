using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 0,i = 0,iRet = 0;
            Console.Write("Number of Elements : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[iNo];
            Console.Write("\nEnter Array Elements : \n");
            for (i = 0;i < iNo; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            iRet = ArraySum.SumArr(Arr, iNo);

            Console.WriteLine("Sum of Array Ellmemnts is : " + iRet);
        }
    }
}
