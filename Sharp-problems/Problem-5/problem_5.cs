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
            // выведет 4?
        }
    }
}
//The ldsfld operation pushes the value of a static field onto the evaluation stack, while the ldstr pushes a reference to a meta data string literal.
//Потому что инструкция a = a + F() выполняется слева направо, компилятор вначале видит a и подставляет текущее значение 0, после этого он видит F(), выполняет функцию и подставляет значение из нее, в результате выходит a = 0 + 1. Если заменить порядок на a = F() + a, тогда будет так, как ты ожидаешь.
