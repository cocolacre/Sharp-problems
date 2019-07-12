
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
		class B378 : A  {
public void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public override void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B378().F(33);
}

}

}
