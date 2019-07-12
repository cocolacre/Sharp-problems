
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
		class B182 : A  {
public void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B182().F(33);
}

}

}
