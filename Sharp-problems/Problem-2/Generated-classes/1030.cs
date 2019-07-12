
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
		class B1031 : A  {
public override void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F<int>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B1031().F(33);
}

}

}
