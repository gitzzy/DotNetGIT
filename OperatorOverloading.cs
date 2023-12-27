using System;

class Base{
int x;
public void pSum(int a){
x = a;
}

public static Base operator -(Base s1){
s1.x = -s1.x;

return s1;
}

public void Show(){
Console.WriteLine(x);
}
}
class OperatorOverloading{
public static void Main(){
Base obj = new Base();
obj.pSum(10);
obj.Show();

Base nObj = -obj; 
nObj.Show();
}
}

