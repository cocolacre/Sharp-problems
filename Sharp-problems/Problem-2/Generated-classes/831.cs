
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
		class B832 : A  {
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<string>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B832().F(33);
}

}

}
