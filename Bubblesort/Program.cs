using System;

namespace Intersetionsort
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int[] arr = {5,2,1,8,3,9,7,4,6};

            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if(arr[i] > arr[i+1])
                    {
                        Swap(ref arr[i], ref arr[i+1]);
                    }
                }
            }
            foreach(int e in arr)
            {
                Console.WriteLine(e);
            }

        }
    }
}
