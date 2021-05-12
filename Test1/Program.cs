using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    namespace Lab6_OOP
    {
        class Program
        {
            //Bиконати завдання за варiантом, в якому оголосити та заповнити одновимірний масив(розмір ввести з клавіатури)
            //згенерованими символами, та відсортувати  - оформити генерацію символів вивід на екран
            //та їх впорядкування у вигляді методів(по варіантам): Cocktail sort;
            static void СocktailSort(int[] arr)
            {
                bool swapped = true;
                int start = 0;
                int end = arr.Length;

                while (swapped == true)
                {

                    // reset the swapped flag on entering the
                    // loop, because it might be true from a
                    // previous iteration.
                    swapped = false;

                    // loop from bottom to top same as
                    // the bubble sort
                    for (int i = start; i < end - 1; ++i)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            int temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                            swapped = true;
                        }
                    }

                    // if nothing moved, then array is sorted.
                    if (swapped == false)
                        break;

                    // otherwise, reset the swapped flag so that it
                    // can be used in the next stage
                    swapped = false;

                    // move the end point back by one, because
                    // item at the end is in its rightful spot
                    end = end - 1;

                    // from top to bottom, doing the
                    // same comparison as in the previous stage
                    for (int i = end - 1; i >= start; i--)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            int temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                            swapped = true;
                        }
                    }

                    // increase the starting point, because
                    // the last stage would have moved the next
                    // smallest number to its rightful spot.
                    start = start + 1;
                    

                }
                foreach (var n in arr)
                    {
                        Console.Write(n + " ");
                    }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Введiть розмiрнiсть масиву: ");
                var n = Console.ReadLine();
                int N = int.Parse(n);
                int[] array = new int[N];
                var rand = new Random();
                for (var i = 0; i < array.Length; i++)
                    array[i] = rand.Next(0, 101);
                Console.Write("Згенерований масив: ");
                foreach (var a in array)
                {
                    Console.Write(a + " ");
                }
                Console.Write("\n");
                Console.Write("Сортований масив методом СocktailSort: ");
                СocktailSort(array);
                Console.ReadKey();
            }
        }
    }
}
