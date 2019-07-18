using System;
using System.Threading;
namespace HeapSort1
{
    public class HeapSort
    {
        public void sort(int[] arr)
        {
            int n = arr.Length;

            //creating a heap by reordering the array;
            Console.WriteLine("Start making heap.");
            Console.Read();
            for (int i = n / 2 - 1; i >= 0; i--)
                make_heap(arr, n, i);
            Console.WriteLine("Done making heap.");
            Console.Read();
            Console.SetCursorPosition(10, 10);
            // extract elements from the heap one by one;
            for (int i = n - 1; i >= 0; i--)
            {
                // move current root to bottom
                var temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // 
                make_heap(arr, i, 0);
            }
        }

        void make_heap(int[] arr, int n, int i)
            // n : heap size
            // i : array index of an element which is the root of the subtree
        {

            printArray(arr);
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            //if left child element is greater than root
            if (l < n && arr[l] > arr[largest])
                largest = l;
            if (r < n && arr[r] > arr[largest])
                largest = r;
            //if the largest element is not the root:
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                //recursively heapify targeted subtree into a heap
                make_heap(arr, n, largest);
            }
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            Console.Clear();
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i]+" ");
                Thread.Sleep(250);
        }

        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 200;
            Random randNum = new Random();
            //int n = randNum.Next(10, 20);
            int n = 20; // array length
            int[] arr = new int[n];
            for  (int i=0; i < n; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }
            Console.WriteLine("\nInitial array is\n");
            printArray(arr);
            Console.Read();

            HeapSort ob = new HeapSort();
            ob.sort(arr);

            Console.WriteLine("\nSorted array is\n");
            printArray(arr);
            Console.Read();
        }
    }
}
