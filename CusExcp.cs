using System;

class CusExcp{

public static void Main(){

try{

int res = cAge();
Console.WriteLine(res);

}catch(ezException e){
Console.WriteLine(e.Message);
}

}
static int cAge(){
 Console.WriteLine("Enter Your Age : ");
int Age1 = int.Parse(Console.ReadLine());

if(Age1 < 0){
throw new Exception("Mf Age can never be Negative");
}
return Age1;
}
}

class ezException : Exception{
ezException(string message): base(message){

}
}
