
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
		class B368 : A  {
public void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<int>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B368().F(33);
}

}

}
