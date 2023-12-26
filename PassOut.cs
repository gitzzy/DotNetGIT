using System;

class PassOut{
public static void Sum(int x, out int y){
	y=x*x;
}

public static void Main(){
	
int m;
Sum(10,out m);
Console.WriteLine(m);
}
}