
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
		class B823 : A  {
public override void F(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F(object a)	{
	Console.WriteLine("B.F(object a)");    
	}
}
public static void Main(string[] args)
{
new B823().F(33);
}

}

}
//B.F(object a) 
