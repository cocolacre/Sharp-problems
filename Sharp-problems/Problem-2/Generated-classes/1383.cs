
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
		class B1384 : A  {
public override void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F<int>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B1384().F(33);
}

}

}
