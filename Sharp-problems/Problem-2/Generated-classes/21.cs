
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
		class B22 : A  {
public void F(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B22().F(33);
}

}

}
