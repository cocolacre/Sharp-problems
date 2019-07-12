
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
		class B552 : A  {
public void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B552().F(33);
}

}

}
