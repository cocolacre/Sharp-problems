namespace Problems
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static IEnumerable<int> F()
        {
            yield return 0;
            Console.WriteLine("1");
        }
        public static void Main(string[] args)
        {
            foreach (int i in F())
            {
                Console.Write($"{i}");
            }
        }
    }
}

