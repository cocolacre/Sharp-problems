
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
		class B240 : A  {
public void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B240().F(33);
}

}

}
//A.F(int) 
