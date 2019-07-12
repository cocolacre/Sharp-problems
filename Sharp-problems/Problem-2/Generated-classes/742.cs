
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
		class B743 : A  {
public void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B743().F(33);
}

}

}
