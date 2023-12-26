using System;

class A{
private int num1;
private int num2;

public A(int num1,int num2){
this.num1=num1;
this.num2=num2;
}

public A(A x){
this.num1=x.num1;
this.num2=x.num2;
}

public void Display(){
Console.WriteLine("Sum of num1 and num2 : "+(num1+num2));
}
}


class CpCon{
public static void Main(){
A obj = new A(5,6);
A obj2 = new A(obj);
obj.Display();
obj2.Display();
}
}