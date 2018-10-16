using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0, col = 0;
            int i = 0, j = 0;
            Console.Write("Enter Number of Row And column : ");
            row = Convert.ToInt32(Console.ReadLine());
            //col = Convert.ToInt32(Console.ReadLine());

            int[][] Arr = new int[row][];

            for(i = 0;i < row; i++)
            {
                Console.Write("Enter Number of Elements : ");
                col = Convert.ToInt32(Console.ReadLine());
                Arr[i] = new int[col];
                for(j = 0;j< col; j++)
                {
                    Arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < row; i++)
            {
                Console.Write(i+" : ");
                
                Arr[i] = new int[col];
                
                for (j = 0; j < col; j++)
                {
                    Console.Write(Arr[i][j]+" ");
                }
            }


        }
    }
}
