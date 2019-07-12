
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
		class B373 : A  {
public void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public override void F(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B373().F(33);
}

}

}
