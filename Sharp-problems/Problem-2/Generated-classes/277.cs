
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
		class B278 : A  {
public void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B278().F(33);
}

}

}
//B.F(params T[] a) 
