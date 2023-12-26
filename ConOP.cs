using System;

public class Base{

public Base(String Name){
Console.WriteLine(Name+" Hello from 1st Con.");
}

public Base(int num){
Console.WriteLine("Hello from con number : "+num);
}
}

class ConOP{
public static void Main(){

Base b = new Base("Devansh");
}
}
