
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
		class B877 : A  {
public override void F(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<int>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B877().F(33);
}

}

}
