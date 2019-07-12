
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
		class B138 : A  {
public void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
}
public static void Main(string[] args)
{
new B138().F(33);
}

}

}
//B.F(object a) 
