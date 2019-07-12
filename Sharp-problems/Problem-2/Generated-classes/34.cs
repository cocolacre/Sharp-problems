
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
		class B35 : A  {
public void F(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B35().F(33);
}

}

}
