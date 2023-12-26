using System;

class ElseIfLadder{
public static void Main(){

Console.Write("Enter your Marks : ");
String M = Console.ReadLine();
int Marks = Convert.ToInt32(M);

	if(Marks==100){
	Console.WriteLine("Perfect Score");
	}
	else if(Marks>=90){
	Console.WriteLine("S Grade");
	}
	else if(Marks>=80){
	Console.WriteLine("A Grade");
	}
	else if(Marks>=70){
	Console.WriteLine("B Grade");
	}
	else if(Marks>=60){
	Console.WriteLine("C Grade");
	}
	else if(Marks>=50){
	Console.WriteLine("D Grade");
	}
	else if(Marks>=40){
	Console.WriteLine("E Grade");
	}
	else if(Marks==0){
	Console.WriteLine("Are you fking Muslim");
	}
	else if(Marks<=30){
	Console.WriteLine("Failed");
	}
	
	else{
	Console.WriteLine("Just Passed");
	}



}
}