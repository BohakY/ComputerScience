using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience
{
    class MergeSort
    {
        //private List<int> inputArray = new List<int>();
        //private static Random generator = new Random();

        //public MergeSort(int size)
        //{
        //    inputArray = new List<int>(size);
        //    for (int i = 0; i < inputArray.Count; i++)
        //    {
        //        inputArray[i] = generator.Next(10, 99);
        //    }
        //}

        public List<int> Sort(List<int> inputArray)
        {
            //displayArrayElements(inputArray);

            if (inputArray.Count <= 1)
                return inputArray;
            //Console.Write(inputArray);

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = inputArray.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(inputArray[i]);
            }
            for (int i = middle; i < inputArray.Count; i++)
            {
                right.Add(inputArray[i]);
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }

        public List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while(left.Count > 0 || right.Count > 0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    //порівняння двох перших елементів, який з них менший
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if(left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if(right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            Console.WriteLine(" \n");
            displayArrayElements(result);
            return result;
        }

        public void displayArrayElements(List<int> array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
        }

    }
}
