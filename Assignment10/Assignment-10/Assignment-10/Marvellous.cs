using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    public class Marvellous
    {
        
        
          public  int iValue=0;
          public int[] arr;
        
            public Marvellous(int iNo)
            {
                iValue=iNo;
               arr = new int[iValue];
            }
            public void ChkPrime()
            {
            int i = 0;
            int f = 0;
            for (i = 2; i <= iValue / 2; i++)
            {
                if (iValue % i == 0)
                {
                    f = 1;
                }
            }
                if(f==1)
                {
                    Console.WriteLine("No is not Prime");
                }
                else
                {
                    Console.WriteLine("No is Prime");
                }
            
            }
            public void ChkPerfect()
            {
            int isum = 0;
            
            int i = 0;
            for(i=1;i<= iValue / 2;i++)
            {
                if(iValue % i==0)
                {
                    isum = isum + i;
                }
            }
            
            if(isum== iValue)
            {
                Console.WriteLine("No is Perfect");
            }
            else
            {
                Console.WriteLine("No is not Perfect");

            }
            }
        public void Accept()
        {
            int i = 0;
            Console.WriteLine("Enter the Elemnts into Array");
                
            for (i=0;i<arr.Length;i++)
            {
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }
        }
        public void EvenDisplay()
        {
            int i = 0;
            Console.WriteLine("Displaying Even No of Array");
            for (i = 0; i <arr.Length; i++)
            {
                if((arr[i]%2)==0)
                {
                    Console.WriteLine("{0}", arr[i]);
                }
                
            }
        }
        public void OddDisplay()
        {
            int i = 0;
            Console.WriteLine("Displaying Odd No of Array");
            for (i = 0; i <arr.Length; i++)
            {
                if ((arr[i] % 2) != 0)
                {
                    Console.WriteLine("{0}", arr[i]);
                }

            }
        }
    }
}
