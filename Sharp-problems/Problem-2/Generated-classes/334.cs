
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
		class B335 : A  {
public void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B335().F(33);
}

}

}
