
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
		class B153 : A  {
public void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<int>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B153().F(33);
}

}

}
