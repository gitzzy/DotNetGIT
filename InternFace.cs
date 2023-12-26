using System;

public interface Haryana{
public void Display();
}

public interface Banglore{
public void Display1();
}

public class Base : Haryana,Banglore{

public void Display(){
Console.WriteLine("Haryana is Sports SuperPower in india");
}

public void Display1(){   
Console.WriteLine("Banglore is IT hub in india");
}

public void Display2(){
Console.WriteLine("Haryana and Banglore are both in india");
}
}

class InternFace{
public static void Main(){

Base obj = new Base();
obj.Display();
obj.Display1();
obj.Display2();
}
}
