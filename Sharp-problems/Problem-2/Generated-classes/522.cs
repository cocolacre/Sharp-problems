
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
		class B523 : A  {
public void F<string>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<int>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B523().F(33);
}

}

}
