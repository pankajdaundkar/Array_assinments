﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_assinments
{
    internal class Assignment_6
    {//   WAP to find and count total number of duplicate elements in an array.
	
        static void Main(string[] args)
        {
            int[] array = new int[8];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Total No Of Duplicates are = {count}");
        }

    }
}

