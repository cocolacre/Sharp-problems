
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
		class B126 : A  {
public void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B126().F(33);
}

}

}
