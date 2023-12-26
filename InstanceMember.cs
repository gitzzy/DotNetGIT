using System;

class Base{
private int insVar;

public Base(int Val){
this.insVar = Val;
}

public void Display(){
Console.WriteLine("Value of Instance Varibale : "+insVar);
}
}

class InstanceMember{
public static void Main(){

Base b = new Base(9);
b.Display();

}
}
