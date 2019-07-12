
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
		class B821 : A  {
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B821().F(33);
}

}

}
