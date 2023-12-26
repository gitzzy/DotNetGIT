using System;
class c7{
public static void Main(){
	
	Console.WriteLine("Enter Any number From 1 to 5 ");
	String a = Console.ReadLine();
	int a1 = Convert.ToInt32(a);
	
	switch(a1){
	case 1 :
	Console.WriteLine("You choose One");
	break;
	case 2:
	Console.WriteLine("You choose Two");
	break;
	case 3:
	Console.WriteLine("You choose three");
	break;
	case 4:
	Console.WriteLine("You choose four");
	break;
	case 5:
	Console.WriteLine("You choose Five");
	break;
	default:
	Console.WriteLine("I said to choose from 1 to 5");
	break;
	
}

}
}