using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            /* Create a list of type int
             * Name the list "evens" - done
             */
            List<int> evens = new List<int>();
            //evens.Add(2);
            //evens.Add(4);
            //evens.Add(6);
            //evens.Add(8);
            //evens.Add(10);
            //Console.WriteLine("Elements in the 'evens' list");
            //{
            //    Console.WriteLine(evens);
            //    Console.WriteLine(evens.Count);
            //    Console.WriteLine(evens.ToArray());
            //    Console.ReadLine();
            //}

            /* Create another list of type int
             * Name the list "odds" - done
             */
            List<int> odds = new List<int>();
            //odds.Add(1);
            //odds.Add(3);
            //odds.Add(5);
            //odds.Add(7);
            //odds.Add(9);
            //Console.WriteLine("Elements in the 'odds' list");
            //{
            //    Console.WriteLine(odds);
            //    Console.WriteLine(odds.Count);
            //    Console.WriteLine(odds.ToArray());
            //    Console.ReadLine();
            //}



            /* Using either a foreach or for loop,
            * iterate through the array you populated with 10 numbers.
            * Inside the scope of the loop,
            * check to see if each number in the array is even or odd.
            * If the number is even, add it to the evens list.
            * If the number is odd, add it to the odds list.
            */
            for (int i = 0; i < numbers.Length; i++) 
            {
                int number = numbers[i];
                if (number % 2 == 0) 
                {
                    evens.Add(number);
                }
                else 
                { 
                    odds.Add(number);
                }
            }
            Console.WriteLine("Even numbers:");
            foreach (var even in evens)
            {
                Console.WriteLine(even);
            }
            Console.WriteLine("Odd numbers:");
            foreach(var odd in odds) 
            {
                Console.WriteLine(odd);
            }


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */


            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            //for (int i = 0; i < odds.Count; i++)
            //{
            //    Console.WriteLine(odds[i]);
            //} 
        }
    }
}
