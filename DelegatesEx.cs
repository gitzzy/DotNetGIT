using System;

delegate int AirthOp(int x, int y);

class Opera{

public static int Add(int a, int b){
return(a+b);
}

public static int Sub(int a, int b){
return(a-b);
}
}

class DelegatesEx{
public static void Main(){

AirthOp op1 = new AirthOp(Opera.Add);
AirthOp op2 = new AirthOp(Opera.Sub);

int Sum1 = op1(10,20);
int Sub1 = op2(20,10);

Console.WriteLine(Sum1);
Console.WriteLine(Sub1);
}
}