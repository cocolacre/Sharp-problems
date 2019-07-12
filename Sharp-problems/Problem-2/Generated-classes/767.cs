
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
		class B768 : A  {
public void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B768().F(33);
}

}

}
