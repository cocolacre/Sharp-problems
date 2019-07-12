
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
		class B551 : A  {
public void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B551().F(33);
}

}

}
