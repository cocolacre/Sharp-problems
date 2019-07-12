namespace Problems
{
    using System;
    internal class Program
    {
        class A
        {
            public virtual void F(int a)
            {
                Console.WriteLine("A.F(int)");
            }
        }
        class B : A
        {
            public void F(object a)
            {
                Console.WriteLine("B.F(object)");
            }
            public override void F(int a)
            {
                Console.WriteLine("B.F(int)");
            }
        }
        class C : B
        {
            public override void F(int a)
            {
                Console.WriteLine("C.F(int)");
            }
            public void F<T>(params T[] a)
            {
                Console.WriteLine("C.F(params T[]");
            }
        }
        public static void Main(string[] args)
        {
            new B().F(33);
            new C().F(33);
        }
    }
}
//Объявляем класс А. Токен virtual позволяет переписать (override) метод F в 
// наследнике. Казалось бы в наследующих классах B и С "должны" 
// вызываться "void F(int a)", ведь эти методы объявлены с токеном override.
// Но происходит перегрузка методов в B и С. Именно перегруженные методы с сигнатурами
// F(object) и F<T>(params T[]).
// Причина происходяшего кроется в аналоге механизме method resolution order
// для си-шарпа. 
// С MSDN:
//    In practice, the rules for determining overload resolution are intended to 
//    find the overload that is "closest" to the actual arguments supplied.
// Казалось бы мы предоставляем два литерала-числа (33) в кач-ве аргументов
// для наших методов, они похожи больше на инт, чем список или просто объект, но
// все же вызываются при оверлоаде не они. Удаляются ли F(int) методы из интерфейса?
