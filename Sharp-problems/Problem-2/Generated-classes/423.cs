
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
		class B424 : A  {
public void Fvoid(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public override void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B424().F(33);
}

}

}
