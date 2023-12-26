using System;

class Sum{
public int x,y;

public void Cal(int v1,int v2){
x = v1;
y = v2;

}

public static Sum operator -(Sum s1){
s1.x = -s1.x;
s1.y = -s1.y;

return s1;
}

public void Dis(){
Console.WriteLine("Value : "+x);
Console.WriteLine("Value : "+y);
}
}

class OpLoad{
public static void Main(){

Sum obj = new Sum();
obj.Cal(40,50);
obj.Dis();

Sum nObj = -obj;

nObj.Dis();
}
}