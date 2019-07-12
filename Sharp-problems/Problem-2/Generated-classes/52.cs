
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
		class B53 : A  {
public void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B53().F(33);
}

}

}
