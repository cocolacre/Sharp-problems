
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
		class B40 : A  {
public void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B40().F(33);
}

}

}
