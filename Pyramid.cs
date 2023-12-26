using System;

class Pyramid{
public static void Main(){

for(int i=0; i<=5; i++){

int space = Math.Abs(i-2);
int star = 5 - (2*space);

for(int j=0; j<space; j++){
Console.Write(" ");
}

for(int j= 1; j<=star; j++){
Console.Write("*");
}
Console.WriteLine();
}


}
}