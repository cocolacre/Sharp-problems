
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
		class B446 : A  {
public void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F<int>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B446().F(33);
}

}

}
