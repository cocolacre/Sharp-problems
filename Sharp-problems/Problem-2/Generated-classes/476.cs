
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
		class B477 : A  {
public void F<string>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B477().F(33);
}

}

}
