
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
		class B8 : A  {
public void F(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B8().F(33);
}

}

}
