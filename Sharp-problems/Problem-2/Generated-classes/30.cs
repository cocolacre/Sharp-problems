
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
		class B31 : A  {
public void F(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B31().F(33);
}

}

}
