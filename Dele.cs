using System;

class Dele{

public delegate int Dell(int x, int y);

public static int Sum(int a, int b){
return(a+b);
}

public static int Sub(int a, int b){
return(a-b);
}

public static void Main(){

Dell d1 = new Dell(Dele.Sum);
Dell d2 = new Dell(Dele.Sub);

Console.WriteLine("Sum of A and B : "+d1(30,30));
Console.WriteLine("Sub of A and B : "+d2(40,20));

}
}
