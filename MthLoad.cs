using System;

class Sum{
	public int Add(int a,int b){
	return a+b;
}
	public int Add(int a, int b, int c){
	return a+b+c;
}
}

class MthLoad{
public static void Main(String[] args){

	Sum s1 = new Sum();
	int X = s1.Add(4,5);
	int Y = s1.Add(4,3,4);
Console.WriteLine(X);
Console.WriteLine(Y);
}
}