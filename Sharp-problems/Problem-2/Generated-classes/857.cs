
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
		class B858 : A  {
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public override void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B858().F(33);
}

}

}
