using System;

class Sub{
public void Dev(int x, int y){
int A = Max(x, y);
Console.WriteLine(A); 
}
int Max(int z, int z1){
int c = (z>z1) ? z:z1;
return(c);
}
}

class NestingMethod{
public static void Main(){

Sub s1 = new Sub();
s1.Dev(53,6);
}
}