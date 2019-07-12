
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
		class B177 : A  {
public void F<T>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B177().F(33);
}

}

}
//B.F(params T[] a) 
