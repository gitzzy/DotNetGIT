using System;

class byRef{
	static void Example(ref int x){
	x=10;
}
	static void Main(){
	 int y = 5;
Console.WriteLine("before passing reference : "+y);
	Example(ref y);
Console.WriteLine("after passing reference : "+y);
}
}