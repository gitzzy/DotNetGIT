using System;

class Sub{
public void Sum(params int[] A){

foreach(int i in A){
Console.WriteLine(i);
}
}
}

class Params{
public static void Main(){

int[] Dev = {10,10,20,30};
int[] Ram = {108,97,40,21};

Sub s = new Sub();

s.Sum(Dev);
s.Sum(Ram);
s.Sum(1000,10001,8000);

}
}