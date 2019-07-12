
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
		class B408 : A  {
public void Fvoid(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<int>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B408().F(33);
}

}

}
