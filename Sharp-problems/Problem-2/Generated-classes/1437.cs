
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
		class B1438 : A  {
public override void F<int>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F<string>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B1438().F(33);
}

}

}
