
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
		class B1223 : A  {
public override void Fvoid(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public void F<string>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B1223().F(33);
}

}

}
