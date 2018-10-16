using System;


namespace MaxMinThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0;
            int max = 0;
            int min = 0;
            Console.Write("Enter Three Number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            helper help = new helper();

            max = help.maxno(n1, n2, n3);
            min = help.minno(n1, n2, n3);

            Console.WriteLine("Maximum Number is : " + max);
            Console.WriteLine("Minimum Number is : " + min);

        }
    }
}
