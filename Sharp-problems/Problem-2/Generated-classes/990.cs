
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
		class B991 : A  {
public override void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B991().F(33);
}

}

}
