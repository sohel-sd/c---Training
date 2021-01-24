using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class DivideArray
    {
        // Dividing Array into 2 arrays and displaying sum of it
        public void Divide()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum1 = 0;
            int sum2 = 0;
            Console.Write("First half array is ");
            for (int i = 0; i < arr1.Length / 2; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr1.Length / 2; i++)
            {
                sum1 += arr1[i];
            }
            Console.WriteLine("The Sum of First Half is :" + sum1);

            Console.Write("Second half array is ");
            for (int i = arr1.Length / 2; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = arr1.Length / 2; i < arr1.Length; i++)
            {
                sum2 += arr1[i];
            }
            Console.WriteLine("The Sum of Second Half is :" + sum2);

            Console.ReadLine();
        }
    }
}
