using System;

class Test1{
	public int sum(int x){

	return (x*x);
}
}
 class Mthd{
	public static void Main(){
		
		Test1 t = new Test1();
		int y = t.sum(5);
	Console.WriteLine(y);
	}
}