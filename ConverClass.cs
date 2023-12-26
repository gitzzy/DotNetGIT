using System;

class ConverClass{
	public static void Main(){
		String a ="100";
	Console.WriteLine("Type before conversion : "+a.GetType());
		int b = Convert.ToInt32(a);
	Console.WriteLine("Type after conversion : "+b.GetType());
	}
}