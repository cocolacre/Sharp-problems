
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
		class B786 : A  {
public override void F(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B786().F(33);
}

}

}
