using System;

class Exception1{
public static void Main(){

try{
int a = 0;
int b = 10/a;
}
catch(DivideByZeroException e){
Console.WriteLine(e.Message);
}
catch(Exception e){
Console.WriteLine(e.Message);
}
finally{
Console.WriteLine("Cleaning the code");
}

}
}
