
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
		class B386 : A  {
public void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public override void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B386().F(33);
}

}

}
