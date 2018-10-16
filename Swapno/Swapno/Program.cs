using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapno
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int iNo1 = 0, iNo2 = 0;


            Console.Write("Enter Two Numbers : ");
            iNo1 = Convert.ToInt32(Console.ReadLine());
            iNo2 = Convert.ToInt32(Console.ReadLine());

            byaddr.SwapByAddr(&iNo1, &iNo2);
            Console.WriteLine("\nAfter Call by Address : ");
            Console.WriteLine("iNo1 = " + iNo1);
            Console.WriteLine("iNo2 = " + iNo2);

            Console.Write("Enter Two Numbers : ");
            iNo1 = Convert.ToInt32(Console.ReadLine());
            iNo2 = Convert.ToInt32(Console.ReadLine());

            byref.SwapByRef(ref iNo1, ref iNo2);
            Console.WriteLine("\nAfter Call by Reference : ");
            Console.WriteLine("iNo1 = " + iNo1);
            Console.WriteLine("iNo2 = " + iNo2);


        }
    }
}
