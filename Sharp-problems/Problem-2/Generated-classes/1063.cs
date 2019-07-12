
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
		class B1064 : A  {
public override void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void Fvoid(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B1064().F(33);
}

}

}
