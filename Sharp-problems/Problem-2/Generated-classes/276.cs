
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
		class B277 : A  {
public void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B277().F(33);
}

}

}
//B.F(object a) 
