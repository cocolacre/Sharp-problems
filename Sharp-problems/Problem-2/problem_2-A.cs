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
			int arg_a = 34;
			int arg_b = 34;
            new B().F(arg_a);
            new C().F(arg_b);
        }
    }
}