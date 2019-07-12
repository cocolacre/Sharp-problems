
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
		class B766 : A  {
public void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B766().F(33);
}

}

}
