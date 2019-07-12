namespace Problems
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = new
            {
                Data = new List<string> { "a", "b", "c" }.GetEnumerator()
            };
            while (a.Data.MoveNext())
            {
				//a.Data.MoveNext()
                Console.WriteLine(a.Data.Current);
            }
        }
    }
}

// Возникают вопросы - почему такой вывод, почему программа не останавливается?
// Data - это get проперти, который каждый раз при обращении возвращает
// енумератор нового листа. 
// каждую итерацию в a.Data.MoveNext() создается новый лист