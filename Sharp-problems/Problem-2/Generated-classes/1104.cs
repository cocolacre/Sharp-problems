
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
		class B1105 : A  {
public override void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void F<string>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B1105().F(33);
}

}

}
