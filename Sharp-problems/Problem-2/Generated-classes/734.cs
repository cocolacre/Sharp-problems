
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
		class B735 : A  {
public void F<int>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
public override void F<string>(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B735().F(33);
}

}

}
