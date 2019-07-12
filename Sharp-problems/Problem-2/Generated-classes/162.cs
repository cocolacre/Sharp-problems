
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
		class B163 : A  {
public void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B163().F(33);
}

}

}
//B.F(params T[] a) 
