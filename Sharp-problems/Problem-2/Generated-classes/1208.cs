
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
		class B1209 : A  {
public override void Fvoid(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public override void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B1209().F(33);
}

}

}
