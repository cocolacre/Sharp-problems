
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
		class B1356 : A  {
public override void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public override void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B1356().F(33);
}

}

}
