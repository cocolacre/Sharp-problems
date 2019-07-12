
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
		class B404 : A  {
public void Fvoid(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B404().F(33);
}

}

}
