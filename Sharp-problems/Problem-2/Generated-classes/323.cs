
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
		class B324 : A  {
public void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void F<string>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B324().F(33);
}

}

}
