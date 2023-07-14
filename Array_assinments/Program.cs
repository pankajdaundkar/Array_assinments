
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
namespace Array_assinments

//1. WAP to search for a given number in an array and accordingly print the index if exist
{
    internal class Assignment_1
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine("Enter number to search");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                Console.WriteLine($"Present At Index = {i}");
                return;
            }
                else
                {
                    Console.WriteLine("Number is not exist in the array");

                }

            }


    }

}



}





