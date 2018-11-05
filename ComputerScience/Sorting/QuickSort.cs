using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience.Sorting
{
    public class QuickSort
    {
        //працює некоректно!!!!!!!!!
        public void Sort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(arr, left, right);

                if(pivot > 1)
                {
                    Sort(arr, left, pivot - 1);
                }
                if(pivot + 1 < right)
                {
                    Sort(arr, pivot + 1, right);
                }
            }
            displayArrayElements(arr);
            
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while(arr[left] < pivot)
                {
                    left++;
                }
                while(pivot < arr[right])
                {
                    right--;
                }
                if(left < right)
                {
                    if (arr[left] == arr[right])
                        return right;
                    //Swap(left, right);

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        private void Swap(int first, int second)
        {
            
        }

        public void displayArrayElements(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }
    }
}
