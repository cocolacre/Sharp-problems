
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
		class B1508 : A  {
public override void F<int>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public override void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B1508().F(33);
}

}

}
