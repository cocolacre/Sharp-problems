
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
		class B765 : A  {
public void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B765().F(33);
}

}

}
