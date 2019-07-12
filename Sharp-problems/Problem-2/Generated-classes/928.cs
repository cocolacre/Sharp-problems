
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
		class B929 : A  {
public override void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<string>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B929().F(33);
}

}

}
