using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.week02
{
    internal class array_task2
    {
        public void Run()
        {
            // input values
            int[] arr1 = { -1, -9, 3, 77 };
            // temporary values
            int arr1Len = arr1.Length;
            int[] arr2 = new int[arr1Len];

            for (int i = 0; i < arr1Len; i++)
            {
                arr2[i] = arr1[arr1Len - i - 1];
            }

            for (int i = 0; i < arr1Len; i++)
            {
                Console.Write(arr2[i] + ",");
            }
        }
    }
}
