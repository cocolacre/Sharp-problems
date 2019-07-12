
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
		class B645 : A  {
public void F<int>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B645().F(33);
}

}

}
