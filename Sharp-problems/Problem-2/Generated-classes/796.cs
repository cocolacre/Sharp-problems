
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
		class B797 : A  {
public override void F(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void F<int>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B797().F(33);
}

}

}
