using System;

class aug13{

public static void Main(){
	String a1 = "Experimental String";
	String b1 = "This is b1";
	
	//Copy
	String a2 = String.Copy(a1);
	String b2 = String.Concat(a1,b1);

//print
Console.WriteLine("a1 : "+a1);
Console.WriteLine("a2 : "+a2);
Console.WriteLine(b2);

//verbatim
String v1 = "hello\n how\n are\n you\n doing";
String v2 =@"hello\n how\n are\n you\n doing";

Console.WriteLine("verbatim : "+v1);
Console.WriteLine("Non-vrbatim : "+v2);

String e1 = "Devansh";
//String e2 = "DEVANSH";

Console.WriteLine("Before insert : "+e1);
String e3 = e1.Insert(7, " Tyagi");
Console.WriteLine("After Insert : "+e3);


Console.WriteLine("To read input from user's keyBoard : ");
String c1 = Console.ReadLine();
Console.WriteLine("You wrote : "+ c1);
}
}