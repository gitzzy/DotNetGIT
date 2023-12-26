using System;
class table{
public static void Main(){

Console.Write("Enter the height of Pyramid : ");
String A = Console.ReadLine();
Console.Write("How Many Pyramid you Want : ");
String X = Console.ReadLine();
int Y = Convert.ToInt32(X);

int B = Convert.ToInt32(A);

for(int l=0; l<Y; l++){
for(int i=0; i<=B; i++){
int space = B-(i);
for(int k=0; k<space; k++){
Console.Write(" ");
}
for(int j=0; j<(2*i-1); j++){


Console.Write("*");
}
Console.WriteLine();

}}
}
}