using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience
{
    public class SelectionSort
    {
        private int[] data;
        private static Random generator = new Random();
        //Create an array of several random numbers
        //створюється об'єкт з переданим розміром і генерується рандомний масив, може перенести цю реалізацію в main?

        public SelectionSort(int size)
        {
            data = new int[size];
            for(int i =0; i < size; i++)
            {
                data[i] = generator.Next(10, 99);
            }
        }

        public void Sort()
        {
            Console.Write("\n(Selection method) Sorted Array Elements: (Step by step)\n\n");
            displayArrayElements();
            int smallest;

            for(int i = 0; i < data.Length - 1; i++)
            {
                //найменшим вибирається перший елемент, при кожній ітерації він посувається на 1
                smallest = i;
                for(int index = i + 1; index < data.Length; index++)
                {
                    //шукає найменший елемент в невідсортованій частині масиву
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    }
                }
                // переміщує найменший елемент з невідсортованої частини в кігець відсортованої
                Swap(i, smallest);
                displayArrayElements();
            }            
        }

        //приймає на вхід 2 елементи масиву і міняє їх місцями
        public void Swap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }

        //виводить елементи з масиву по одному
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
