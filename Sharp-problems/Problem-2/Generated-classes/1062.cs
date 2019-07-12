
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
		class B1063 : A  {
public override void F<T>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B1063().F(33);
}

}

}
