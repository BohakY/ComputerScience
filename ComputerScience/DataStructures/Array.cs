using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience.DataStructures
{
    public class Array
    {
        int[] nums = new int[4];

        int[] nums2 = new int[4] { 3, 4, 2, 7 };

        int[] nums3 = new[] { 4, 6, 5, 7, 4, 3 };

        int[] nums4 = { 2, 7, 532, 2 };

        public static void MultiDimensionArray()
        {
            int[,] mas = {{1,2,3}, {4,5,6}, {7,8,9},{10,11,12}};
            foreach(int i in mas)
                Console.Write($"{i}");
            Console.WriteLine();

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i,j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
