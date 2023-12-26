using System;

class byValue{
	static void Value(int x){
	x=10;
}
	static void Main(){
	int y = 20;
	Console.Write("before "+y);
	Value(y);
	Console.Write("After "+y);
}
}