
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
		class B1397 : A  {
public override void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B1397().F(33);
}

}

}
