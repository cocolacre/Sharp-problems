
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
		class B209 : A  {
public void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B209().F(33);
}

}

}
