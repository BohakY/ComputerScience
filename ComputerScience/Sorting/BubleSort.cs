using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience
{
    public class BubleSort
    {
        private int[] data;
        private static Random generator = new Random();

        public BubleSort(int size)
        {
            data = new int[size];
            for(int i = 0; i < size; i++)
            {
                data[i] = generator.Next(1, 129);
            }
        }

        public void Sort()
        {
            Console.Write("\n(Buble method) Sorted Array Elements: (Step by step)\n\n");
            displayArrayElements();

            for(int i = 0; i < data.Length - 1; i++)
            {
                for(int j = 1; j < data.Length; j++)
                {
                    //порівнює перше значення з наступним, якщо більше, то мінє місцями і порівнює з наступним
                    if(data[j] < data[j - 1])
                    {
                        Swap(j - 1, j);
                        displayArrayElements();
                    }
                    //щоб побачити всі кроки
                    //displayArrayElements();
                }
            }
        }

        public void Swap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }

        public void displayArrayElements()
        {
            foreach(var element in data)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }
    }
}
