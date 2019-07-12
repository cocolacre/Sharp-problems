
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
		class B966 : A  {
public override void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void Fvoid(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B966().F(33);
}

}

}
