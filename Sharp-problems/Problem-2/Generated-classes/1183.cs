
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
		class B1184 : A  {
public override void Fvoid(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<string>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B1184().F(33);
}

}

}
