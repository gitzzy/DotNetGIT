using System;

class Unary{
public static void Main(){

Console.Write("Enter Your Age : ");
int Age = int.Parse(Console.ReadLine());

String res;
res = (Age > 0)? "Pass" : "Fail";
Console.WriteLine(res);
}
}
