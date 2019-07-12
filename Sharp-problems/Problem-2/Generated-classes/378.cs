
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
		class B379 : A  {
public void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public override void Fvoid(params T[] a)	{
	Console.WriteLine("B.F(params T[] a)");    
	}
}
public static void Main(string[] args)
{
new B379().F(33);
}

}

}
