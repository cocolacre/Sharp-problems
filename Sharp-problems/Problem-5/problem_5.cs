namespace Problems
{
    using System;

    internal class Program
    {
        private static int a = 0;

        static int F()
        {
            a = a + 3;
            return 1;
        }
        public static void Main(string[] args)
        {
            a += F();
            Console.WriteLine(a);
        }
    }
}

