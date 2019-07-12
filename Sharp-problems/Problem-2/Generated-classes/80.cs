
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
		class B81 : A  {
public void F(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B81().F(33);
}

}

}
//B.F(object a) 
