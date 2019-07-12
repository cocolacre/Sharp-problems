
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
		class B624 : A  {
public void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B624().F(33);
}

}

}
