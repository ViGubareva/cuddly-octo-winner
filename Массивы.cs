using System;

namespace ArraySorting

{
    class Programm
    {
        static void Main ()
        {
            Int[] arr = new Int[] {-3, 4, 666, 19, 100500, 42, -10, 0}
            // посмотреть изначальное состояние
            Console.Write("Start ");
            for (Int i = 0; i < arr.Length; i += 1)
            {
                Console.Write(" {0}", arr[i]);
            }
            for (Int i = 0; i < arr.Length - 1; i += 1)
            {
                // найти минимальное:
                Int iMin = i;
                for (Int k = i + 1; k < arr.Length; k += 1)
                {
                    if (arr[k] < arr[iMin])
                    {
                        iMin = k;
                    }
                }
                // поменять значения местами
                if (iMin != i)
                {
                    Int f = arr[iMin];
                    arr[iMin] = arr[i];
                    arr[i] = f;
                }
                // вывод результата сортировки пошагово
                Console.Write("\nstep {0} :", i);
                for (Int j = 0; j < arr.Length; j += 1)
                {
                    Console.Write(" {0}", arr[j]);
                }
            }
        }
    }
}   
