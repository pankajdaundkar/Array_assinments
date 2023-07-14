using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Array_assinments
{//2.	Write two methods that return the average of an array with following headers.
 //i.  public static int average(int[] array)
 //ii. public static double average(double[] array).
 //iii.Write main and invoke the 2 methods.

    public class Assignment_10
    {
        public static int average(int[] array)
        {
            int sum = 0;
            int average = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            average = sum / array.Length;
            return average;
        }
        public static double average(double[] array)
        {
        double sum = 0;
        double average = 0;
        }
         
           
        static void Main(string[] args)
        {
            int[] arr = new int[5] {5,5,5,5,5};
            int res = average(arr);
            Console.WriteLine(res);
        }
    }
}
