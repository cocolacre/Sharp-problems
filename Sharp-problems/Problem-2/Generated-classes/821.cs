
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
		class B822 : A  {
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B822().F(33);
}

}

}
//B.F(int a) 
