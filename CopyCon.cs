using System;

class Base{

int val;

public Base(int a){
this.val= a;
Console.WriteLine("OG says : "+val);
}
public Base(Base b1){
val = b1.val;
Console.WriteLine("Copy Says : "+val);
}

}

class CopyCon{
public static void Main(){

Base b1 = new Base(5);
Base b2 = new Base(b1); 
}
}
