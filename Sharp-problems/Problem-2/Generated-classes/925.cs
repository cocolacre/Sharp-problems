
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
		class B926 : A  {
public override void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B926().F(33);
}

}

}
