
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
		class B327 : A  {
public void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B327().F(33);
}

}

}
