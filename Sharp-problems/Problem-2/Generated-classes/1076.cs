
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
		class B1077 : A  {
public override void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B1077().F(33);
}

}

}
