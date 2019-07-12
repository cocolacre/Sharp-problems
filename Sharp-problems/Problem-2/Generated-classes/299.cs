
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
		class B300 : A  {
public void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B300().F(33);
}

}

}
