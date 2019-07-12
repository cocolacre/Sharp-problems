
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
		class B52 : A  {
public void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<string>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B52().F(33);
}

}

}
