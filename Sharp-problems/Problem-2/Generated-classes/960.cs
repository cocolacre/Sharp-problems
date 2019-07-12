
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
		class B961 : A  {
public override void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B961().F(33);
}

}

}
