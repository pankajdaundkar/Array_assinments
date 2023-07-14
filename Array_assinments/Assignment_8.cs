﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_assinments
{//  WAP to print all unique elements in the array.
    internal class Assignment_8
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            Console.WriteLine("Enter Array Elements");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            int[] freq = new int[max + 1];

            for (int i = 0; i < array.Length; i++)
            {
                freq[array[i]]++;
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] == 1)
                {
                    Console.WriteLine($" {i}, ");
                }
            }
        }

    }
}

