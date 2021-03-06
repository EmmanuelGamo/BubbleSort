﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            int i;
            Console.WriteLine("Input 10 numbers:");
            for (i = 0; i < 10; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe numbers in the array are: ");
            PrintElements(Numbers);
            BubbleSort(Numbers);
            Console.Write("\n Bubble Sorted: ");
            PrintElements(Numbers);
            Console.ReadKey();
        }
        public static void BubbleSort(int[] Numbers)  //using Bubble Sort
        {
            int space;

            for (int i = 0; i < Numbers.Length -1; i++) 
            {
                for (int x = 0; x < Numbers.Length -(i+1); x++) 
                {
                if (Numbers[x] > Numbers[x + 1])
                    {
                        space = Numbers[x + 1];
                        Numbers[x + 1] = Numbers[x];
                        Numbers[x] = space;
                    }
                }
            }

        }
        public static void PrintElements(int[] Numbers)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", Numbers[i]);
            }
        }
    }
}
