
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
		class B1487 : A  {
public override void F<int>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B1487().F(33);
}

}

}
