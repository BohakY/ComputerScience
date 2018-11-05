using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience.Sorting
{
    public class HeapSort
    {
        private int[] data;
        private static Random generator = new Random();

        public HeapSort(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(1000, 9999);
            }
            displayArrayElements(data);

        }

        public void Sort()
        {
            int heapSize = data.Length;

            buildMaxHeap(data);

            for(int i = heapSize - 1; 1 <= i; i--)
            {
                swap(data, i, 0);
                heapSize--;
                sink(data, heapSize, 0);
            }
            displayArrayElements(data);
        }

        private static void buildMaxHeap(int[] array)
        {
            int heapSize = array.Length;
            for(int i = (heapSize/2)-1; 0 <= i; i--)
            {
                sink(array, heapSize, i);

            }
        }

        private static void sink(int[] array, int heapSize, int toSinkPos)
        {
            if(getLeftKidPos(toSinkPos) >= heapSize)
            {
                //нема лівих дітей = нема ніяких дітей
                return;
            }

            int largestKidPos;
            bool leftIsLargest;

            if(getRightKidPos(toSinkPos) >= heapSize || array[getRightKidPos(toSinkPos)].CompareTo(array[getLeftKidPos(toSinkPos)]) < 0)
            {
                largestKidPos = getLeftKidPos(toSinkPos);
                leftIsLargest = true;
            }
            else
            {
                largestKidPos = getRightKidPos(toSinkPos);
                leftIsLargest = false;
            }
            //CompareTo - порівнює вміст 
            // obj > 0 то поточний об'єкт має знаходитись після того, що передаєтья через параметр! obj < 0 - перед! = 0 об'єкти рівні!
            if(array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
            {
                swap(array, toSinkPos, largestKidPos);
                displayArrayElements(array);
                if (leftIsLargest)
                {
                    sink(array, heapSize, getLeftKidPos(toSinkPos));

                }
                else
                {
                    sink(array, heapSize, getRightKidPos(toSinkPos));
                }
            }
        }

        private static int getLeftKidPos(int parentPos)
        {
            return (2 * (parentPos + 1)) - 1;
        }

        private static int getRightKidPos(int parentPos)
        {
            return 2 * (parentPos + 1);
        }

        private static void swap(int[] array, int first, int second)
        {
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        public static void displayArrayElements(int[] data)
        {
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }

    }
}
