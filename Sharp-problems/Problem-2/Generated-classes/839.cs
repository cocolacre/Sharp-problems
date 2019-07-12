
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
		class B840 : A  {
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public override void F(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B840().F(33);
}

}

}
