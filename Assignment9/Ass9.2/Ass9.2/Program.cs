using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ass9._2
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

            Class1 obj = new Class1();
            //mobs.DisplayRange(istart, iend);
            Thread t1 = new Thread(() => obj.DisplayRangeF(istart,iend));
            Thread t2 = new Thread(() => obj.DisplayRangeB(istart, iend));

            t1.Name = "DisplayRangeF";
            t2.Name = "DisplayRangeB";
            

            Console.WriteLine("Thread Name:{0}", t1.Name);
            Console.WriteLine("Thread Priority:{0}", t1.Priority);
            Console.WriteLine("Thread Id:{0}", t1.ManagedThreadId);
            if(t1.IsAlive)
            {
                Console.WriteLine("Thread t1 is alive");
            }
            else
            {
                Console.WriteLine("Thread t1 is  not alive");
            }
            
            t1.Start();
            t1.Join();
            t2.Start();

            Console.WriteLine("Thread Name:{0}", t2.Name);
            Console.WriteLine("Thread Priority:{0}", t2.Priority);
            Console.WriteLine("Thread Id:{0}", t2.ManagedThreadId);
            if (t2.IsAlive)
            {
                Console.WriteLine("Thread t2 is alive");
            }
            else
            {
                Console.WriteLine("Thread t2 is  not alive");
            }
        }
    }
}
