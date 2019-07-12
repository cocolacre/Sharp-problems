
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
		class B1026 : A  {
public override void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B1026().F(33);
}

}

}
