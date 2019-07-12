
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
		class B340 : A  {
public void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B340().F(33);
}

}

}
