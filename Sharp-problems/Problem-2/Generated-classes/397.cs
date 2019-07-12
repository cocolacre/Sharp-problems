
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
		class B398 : A  {
public void Fvoid(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B398().F(33);
}

}

}
