using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 0, cnt = 0;
            Console.Write("ENter the Number : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            cnt = helper.cntdig(iNo);

            Console.WriteLine("Count of Digit is : " + cnt);

        }
    }
}
