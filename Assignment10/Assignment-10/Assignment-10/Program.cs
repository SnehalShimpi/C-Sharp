using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int No = 0;
            Console.WriteLine("Enter the value number");
            No = Convert.ToInt32(Console.ReadLine());

           // Marvellous ob = new Marvellous(No);
            MarvellousNew obj = new MarvellousNew(No);

            Thread t1 = new Thread(new ThreadStart(obj.ChkPerfect));
            Thread t2 = new Thread(new ThreadStart(obj.ChkPrime));

            t1.Start();
            t2.Start();
            t2.Join();

            Thread t3 = new Thread(new ThreadStart(obj.EvenDisplay));
            Thread t4 = new Thread(new ThreadStart(obj.OddDisplay));

            obj.Accept();
            t3.Start();
            t4.Start();
            t4.Join();

            Thread t5 = new Thread(new ThreadStart(obj.Max));
            Thread t6 = new Thread(new ThreadStart(obj.Min));

            
            
            

            t5.Start();
            t6.Start();
            


        }
    }
}

