
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
		class B280 : A  {
public void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B280().F(33);
}

}

}
//A.F(int) 
