
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
		class B1403 : A  {
public override void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<int>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B1403().F(33);
}

}

}
