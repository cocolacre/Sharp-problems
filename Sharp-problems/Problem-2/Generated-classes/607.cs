
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
		class B608 : A  {
public void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B608().F(33);
}

}

}
