
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
		class B999 : A  {
public override void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public override void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B999().F(33);
}

}

}
