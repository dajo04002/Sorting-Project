using System;

namespace Insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, key, i;
            
            int[] arr = {5,2,1,8,3,9,7,4,6};


            for (i = 0; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;
                
                while(j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            foreach(int e in arr)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
