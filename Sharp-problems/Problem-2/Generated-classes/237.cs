
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
		class B238 : A  {
public void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B238().F(33);
}

}

}
//B.F(object a) 