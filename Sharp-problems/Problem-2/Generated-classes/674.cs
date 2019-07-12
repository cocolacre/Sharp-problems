
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
		class B675 : A  {
public void F<int>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B675().F(33);
}

}

}
