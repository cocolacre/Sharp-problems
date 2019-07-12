
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
		class B753 : A  {
public void F<int>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B753().F(33);
}

}

}
