
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
		class B1507 : A  {
public override void F<int>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public override void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B1507().F(33);
}

}

}
