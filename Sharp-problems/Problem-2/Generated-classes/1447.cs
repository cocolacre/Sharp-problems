
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
		class B1448 : A  {
public override void F<int>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B1448().F(33);
}

}

}
