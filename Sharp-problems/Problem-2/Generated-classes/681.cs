
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
		class B682 : A  {
public void F<int>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B682().F(33);
}

}

}
