
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
		class B1385 : A  {
public override void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B1385().F(33);
}

}

}
