using System;
using System.Linq;
using System.Security.Cryptography;

namespace scrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 1000;
            int[] arr = new int[length];
            
            for (int i = 0; i <= length - 1; i++)
            {
                arr[i] = i + 1;
            }

            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
