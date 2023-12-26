using System;

public class p1{
	public static void Main(){

	Console.WriteLine("Enter your input 1 :  ");
	String a = Console.ReadLine();
	Console.WriteLine("Enter your input 2 :  ");
	String b = Console.ReadLine();
	
	int a1 = int.Parse(a);
	int b1 = int.Parse(b);

	Console.WriteLine("Before Parsing Addition : "+(a+b));	
	Console.WriteLine("After Parsing Addition : "+(a1+b1));
	
	
	}

}
