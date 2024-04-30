using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;


namespace Sort
{
    public  static class Sort <T>  where T : IComparable<T>
    {
        // Сортировка пузырьком
        public static T[] BubbleSorting(T[] array)
        {
           
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swop(ref array[j], ref array[j + 1]);
                        count++;
                    }
                }
                if (count == 0) break;
            }
            return array;
        }

        // Сортировка шейкерная
        public static T[] ShakerSorting(T[] array)
        {
            int start = 0, end = array.Length - 1;

            while (start <= end)
            {
                int count = 0;
                for (int i = start; i < end; i++)
                {
                    T first = array[i];
                    T second = array[i + 1];
                    if (first.CompareTo(second) > 0)
                    {
                        Swop(ref array[i], ref array[i + 1]);
                        count++; 
                    }
                   
                }
                if (count == 0) break;
                else end--;


                for (int i = end; i > start; i--)
                {
                    count = 0;
                    T first = array[i];
                    T second = array[i - 1];
                    if (first.CompareTo(second) < 0)
                    {
                        Swop(ref array[i], ref array[i - 1]);
                        count++;
                    }
                }
                if (count == 0) break;
                else start++;
            }
            return array;
        }

        // сортировка вставками
        public static T[] MakeSorting(T[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var item = array[i];
                var j = i;
                while (j > 0 && item.CompareTo(array[j - 1]) == -1)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = item;
            }

            return array;
        }
        private static void Swop( ref T item, ref T itemNext)
        {
            T helpItem = item;
            item = itemNext;
            itemNext = helpItem;
        }
    }
}
