
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
		class B216 : A  {
public void F<T>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B216().F(33);
}

}

}
//B.F(int a) 
