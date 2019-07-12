
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
		class B1399 : A  {
public override void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<string>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B1399().F(33);
}

}

}
