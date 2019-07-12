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
public static void Main(string[] args)
        {
            new B().F(33);
        }
    }
}