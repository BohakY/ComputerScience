using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience
{
    //придумати як адаптувати всі алгоритми пошуку під абстрактний клас, інтерфейс і тд
    public abstract class Sort
    {
        private int[] data;
        private static Random generator = new Random();
        //Create an array of several random numbers
        //створюється об'єкт з переданим розміром і генерується рандомний масив, може перенести цю реалізацію в main?

        public Sort(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(10, 99);
            }
        }
    }
}
