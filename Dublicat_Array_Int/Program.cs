using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublicat_Array_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 2, 2, 2, 6 };
            int n = CountDuplicatePairs(array);
            Console.WriteLine(n);
        }

        static int CountDuplicatePairs(int[] arr)
        {
            int temp = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    temp++;
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && arr[j] != 0)
                    {
                        count++;
                        arr[i] = 0;
                        arr[j] = 0;
                        continue;
                    }
                }
            }
            return count + temp / 2;
        }
    }
}
