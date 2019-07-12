
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
		class B1236 : A  {
public override void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B1236().F(33);
}

}

}
