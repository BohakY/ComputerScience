using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerScience.Sorting;

namespace ComputerScience
{
    public class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10;

            HeapSort heap = new HeapSort(arraySize);
            heap.Sort();
            Console.ReadKey();


            Random generator = new Random();         
            List<int> inputArray = new List<int>(arraySize);
                for (int i = 0; i < inputArray.Capacity; i++)
                {
                inputArray.Add(generator.Next(0, 100));           
                }

            int[] unsorted = new int[arraySize];
            for(int i = 0; i < unsorted.Length; i++)
            {
                unsorted[i] = generator.Next(12, 44);
            }
            QuickSort quick = new QuickSort();
            quick.Sort(unsorted, 0, unsorted.Length - 1);
            Console.ReadKey();


            MergeSort merge = new MergeSort();
            inputArray.ForEach(i => Console.Write("{0}" + " ", i));
            List<int> sorted = merge.Sort(inputArray);
            sorted.ForEach(i => Console.Write("{0}"+ " ", i));
            Console.ReadKey();


            InsertionSort insertion = new InsertionSort(arraySize);
            insertion.Sort();
            Console.ReadKey();

            SelectionSort selection = new SelectionSort(arraySize);
            selection.Sort();
            Console.ReadKey();

            BubleSort buble = new BubleSort(arraySize);
            buble.Sort();
            Console.ReadKey();
        }
    }
}
