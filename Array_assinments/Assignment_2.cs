using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
namespace Array_assinments
{
//    Write two methods that return the average of an array with following headers.
//i.  public static int average(int[] array)
//ii. public static double average(double[] array).
//iii.Write main and invoke the 2 methods
    internal class Assignment_2
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[8];
            Console.WriteLine("Enter Array Elements");

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            double[] doubleArray = new double[8];
            Console.WriteLine("Enter Double Array Elements");

            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            int intAverage = Average(intArray);
            double doubleAverage = Average(doubleArray);
            Console.WriteLine("Average of int array " + intAverage);
            Console.WriteLine("Average of double array " + doubleAverage);
        }

        public static int Average(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                sum = sum + num;
            }

            int average = sum / array.Length;
            return average;
        }
        public static double Average(double[] array)
        {
            double sum = 0;

            foreach (double num in array)
            {
                sum = sum + num;
            }

            double average = sum / array.Length;
            return average;
        }

    }
}

