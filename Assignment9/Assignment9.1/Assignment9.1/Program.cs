using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int istart = 0, iend = 0;

            Console.WriteLine("Enter the Start");
            istart = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the end");
            iend = Convert.ToInt32(Console.ReadLine());

            Marvellous mobs = new Marvellous(istart,iend);
            //mobs.DisplayRange(istart, iend);
            Thread t1 = new Thread(mobs.DisplayRange);
            
            t1.Start();
        }
    }
}
