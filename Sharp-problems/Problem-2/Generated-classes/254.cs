
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
		class B255 : A  {
public void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B255().F(33);
}

}

}
//B.F(int a) 
