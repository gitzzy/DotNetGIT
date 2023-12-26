using System;

public class Animal{

protected int a;
public void display(){
Console.WriteLine("We are Maximals "+a);
}
}

public class Bird {
public void display(){
Console.WriteLine("We are Panchi");
}
}

public class Inherit : Animal{
public static void Main(String[] args){

Inherit obj =  new Inherit();
obj.a=10;
obj.display();
Console.WriteLine("Value of A : "+obj.a);
}
 
}