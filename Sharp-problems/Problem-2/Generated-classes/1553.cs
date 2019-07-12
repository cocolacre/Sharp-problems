
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
		class B1554 : A  {
public override void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<string>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B1554().F(33);
}

}

}
