
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
		class B1411 : A  {
public override void F<int>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B1411().F(33);
}

}

}
