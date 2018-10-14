
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_10
{
     class MarvellousNew :  Marvellous
    { 
        public MarvellousNew(int iNo):base(iNo)
        {
            
        }
        public void Max()
        {
           
            int max = 0;
            int i = 0;
            for(i=0;i<base.iValue; i++)
            {
                if(max < base.arr[i])
                {
                    max = base.arr[i];
                }
            }
            Console.WriteLine("Maximum no is {0}", max);

        }
        public void Min()
        {
            int min = base.arr[0];
            int i = 0;
            for (i = 0; i <base.iValue; i++)
            {
                if (min > base.arr[i])
                {
                    min = base.arr[i];
                }
            }
            Console.WriteLine("Maximum no is {0}", min);

        }
    }
    
}
