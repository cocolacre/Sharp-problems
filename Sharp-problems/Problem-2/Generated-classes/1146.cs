
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
		class B1147 : A  {
public override void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<string>(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B1147().F(33);
}

}

}
