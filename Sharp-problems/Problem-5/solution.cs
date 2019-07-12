namespace Problems
{
    using System;

    internal class Program
    {
        private static int a = 0;
        private static int b = 0;

        static int F()
        {
            a = a + 3;
            return 1;
        }
		
		static int H()
        {
            b = b + 3;
            return 1;
        }
        public static void Main(string[] args)
        {
            a += F(); //same as a=a+F();
            b = H() + b; //в эвал.стак грузится 1 + 3, где тройка уже вычислена 
			             // в левой части выражения.
            Console.WriteLine(a); // 1
            Console.WriteLine(b); // 4
        }
    }
}

// можно подумать, что вывод будет 4.
// почему не так, и выводится 1?
// Компилятор читает строку a = a + F() слева направо.
// Встретив a первый раз, он подставляет в вычисляемое выражение 
// значение 0, имеющееся на этот момент,
// которое и отправляется в evaluation stack.
// Далее значение 0 уже загружено в ES, происходит вызов функции F
// который НЕ меняет вычисляемое значение для выражения a += F(),
// хоть и меняет значение статической переменной a.
// Функция F возвращает единицу, которая прибавляется к нулю
// и выражение вычисляется соответственно как 0+1=1, данное значение и
// присваивается переменной a, которая выводится в консоль.
// Например, заменив порядок на a = F() + a, мы получим 
// a = 1 + (0 + 3). (см. solution.il)
// IL_0001:  ldsfld     int32 Problems.Program::a
// IL_0006:  call       int32 Problems.Program::F()
// IL_000b:  add
// IL_000c:  stsfld     int32 Problems.Program::a
// IL_0011:  call       int32 Problems.Program::H()
// IL_0016:  ldsfld     int32 Problems.Program::b
// IL_001b:  add
// IL_001c:  stsfld     int32 Problems.Program::b
// IL_0021:  ldsfld     int32 Problems.Program::a