
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
		class B1222 : A  {
public override void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F<string>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B1222().F(33);
}

}

}
