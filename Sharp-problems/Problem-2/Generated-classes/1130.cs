
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
		class B1131 : A  {
public override void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B1131().F(33);
}

}

}
