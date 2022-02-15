using System;
using System.Linq;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Threading;

namespace scrambler
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static public int Partition(int[] arr, int left, int right) {
         int pivot;
         pivot = arr[left];
         while (true) {
            while (arr[left] < pivot) {
               left++;
            }
            while (arr[right] > pivot) {
               right--;
            }
            if (left < right) {
               int temp = arr[right];
               arr[right] = arr[left];
               arr[left] = temp;
            } else {
               return right;
            }
         }
      }
      static public void quickSort(int[] arr, int left, int right) {
         int pivot;
         if (left < right) {
            pivot = Partition(arr, left, right);
            if (pivot > 1) {
               quickSort(arr, left, pivot - 1);
            }  
            if (pivot + 1 < right) {
               quickSort(arr, pivot + 1, right);
            }
         }
      }
        
        static void Main(string[] args)
        {
            //Scrambler
            int length = 16000;
            int[] arr = new int[length];

            for (int o = 0; o <= length - 1; o++)
            {
                arr[o] = o + 1;
            }
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();
            Console.WriteLine("Scrambled: ");
            foreach (var o in arr)
            {
                Console.WriteLine(o);
            }
            //Scrambler

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Sortering
             
             Partition(arr, 0, length-1);
             quickSort(arr, 0, length-1);

     
     
            
            //Sortering

            stopwatch.Stop();

            Console.WriteLine("Sorted: ");
            foreach(var e in arr)
            {
                Console.WriteLine(e);
            }
                
                Console.WriteLine("Elapsed Time is: {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}
