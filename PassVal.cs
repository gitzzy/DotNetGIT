using System;


class PassVal{

public static void Para(ref int x){
	x=x+10;
Console.WriteLine("Value of x : "+x);
}


public static void Main(){

int y = 100;
Para(ref y);
Console.WriteLine("Value of y : "+y);

}
}