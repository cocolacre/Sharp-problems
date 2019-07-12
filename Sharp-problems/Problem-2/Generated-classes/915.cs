
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
		class B916 : A  {
public override void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F<int>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B916().F(33);
}

}

}
