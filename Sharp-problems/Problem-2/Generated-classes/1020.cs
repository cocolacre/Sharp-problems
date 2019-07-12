
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
		class B1021 : A  {
public override void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B1021().F(33);
}

}

}
