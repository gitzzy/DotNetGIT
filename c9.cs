using System;
class c9{
public static void Main(){
	
	int a = 100;
	Object b = a;
	a = 200;
	int i = (int)b;
	
	Console.WriteLine("Value of a : "+a);
	Console.WriteLine("Value of b : "+b);
	Console.WriteLine("Value of i : "+i);
}
}