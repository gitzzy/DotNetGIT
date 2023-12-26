using System;

class PassRef{
static void Swap(ref int x,ref int y){
int temp=x;
x=y;
y=temp;
}
public static void Main(){

int a=10;
int b=100;
Console.WriteLine("Before Swapping : ");
Console.WriteLine("Value of a -> "+a);
Console.WriteLine("Value of b -> "+b);
Swap(ref a,ref b);
Console.WriteLine("After Swapping : ");
Console.WriteLine("Value of a -> "+a);
Console.WriteLine("Value of b -> "+b);


}
}