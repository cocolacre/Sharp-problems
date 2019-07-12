
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
		class B1424 : A  {
public override void F<int>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B1424().F(33);
}

}

}
