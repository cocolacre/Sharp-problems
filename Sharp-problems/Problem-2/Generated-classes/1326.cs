
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
		class B1327 : A  {
public override void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public void F(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B1327().F(33);
}

}

}
