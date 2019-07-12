
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
		class B639 : A  {
public void F<int>(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
public void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B639().F(33);
}

}

}
