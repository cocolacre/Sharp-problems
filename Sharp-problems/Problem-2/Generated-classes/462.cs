
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
		class B463 : A  {
public void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F<string>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B463().F(33);
}

}

}
