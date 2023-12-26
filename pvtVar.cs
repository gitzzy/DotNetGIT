using System;

class A{
private int valA;

//properties srtart --------------------->

public int valB{
get{
return valA;
}
set{
valA=value;
}
}
//end=----------------------------> 
}
class pvtVar{
	public static void Main(){
	A obj = new A();
	obj.valB=5;
	Console.WriteLine(obj.valB);
}
}