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
		class B1 : A  {
public void F(object a)	{
	Console.WriteLine("F(object a)");    
	}
            public override void F(int a) {

			Console.WriteLine("F(int a)");    
	}
}
public static void Main(string[] args)
{
new B1().F(33);
}

}

}
