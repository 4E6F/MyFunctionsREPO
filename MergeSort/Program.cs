using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testarray = new int[] { 5, 8, 23, 6, 2, 6, 8, 132, 86 };
            Console.WriteLine("InputArray: " + ArraytoString(testarray));
            MergeSort mergeSort = new MergeSort();

            mergeSort.UseSortAlgo(testarray, 0, testarray.Length-1);

            Console.WriteLine("SortedArray: " + ArraytoString(testarray));
        }

        static string ArraytoString(int[] arr) 
        {
            string strarry = "[";

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1)
                {
                    strarry += arr[i];
                    strarry += ", ";
                }
                else
                {
                    strarry += arr[i];
                }
                
            }
            strarry += "]";
            return strarry;
        }
    }
}
