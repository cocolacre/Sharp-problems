
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
		class B1474 : A  {
public override void F<int>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public override void Fvoid(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B1474().F(33);
}

}

}
