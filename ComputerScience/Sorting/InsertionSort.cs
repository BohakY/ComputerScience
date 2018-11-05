using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience
{
    public class InsertionSort
    {
        private int[] data;
        private static Random generator = new Random();

        public InsertionSort(int size)
        {
            data = new int[size];
            for(int i = 0; i < size; i++)
            {
                data[i] = generator.Next(100, 200);
            }

        }

        public void Sort()
        {
            Console.Write("\n(Insertion method) Sorted Array Elements: (Step by step)\n\n");
            displayArrayElements();
            for(int i = 0; i < data.Length - 1; i++)
            {
                //бере кожне число по черзі і відразу ставить її в потрібне місце у відсортовану частину масиву
                //порівнюючи з елементами відсортованої частини
                //таким чином невідсортований масив зменш на 1 при кожному проході
                for(int j = i + 1; 0 < j; j--)
                {
                    if(data[j-1] > data[j])
                    {
                        Swap(j - 1, j);
                        displayArrayElements();
                    }
                    //щоб побачити повний алгоритм
                    //displayArrayElements();
                }
                //Console.Write("\n\n");

            }
        }

        public void Swap(int first, int second)
        {
            int temp = data[first];
            data[first] = data[second];
            data[second] = temp;
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
