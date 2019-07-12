
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
		class B358 : A  {
public void Fvoid(int a)	{
	Console.WriteLine("B.F(int a)");    
	}
public void F<T>(string[] a)	{
	Console.WriteLine("B.F(string[] a)");    
	}
}
public static void Main(string[] args)
{
new B358().F(33);
}

}

}
