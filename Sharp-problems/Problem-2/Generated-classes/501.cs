
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
		class B502 : A  {
public void F<string>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B502().F(33);
}

}

}
