using System;

 class Base{

private static int val{
get;
set;
}

public int val1;
public Base(){
val++;
val1 = val;
}
}

class SharedClass{
public static void Main(){

Base b1 = new Base();
Base b2 = new Base();

Console.WriteLine("Count : "+Base.val1);
}
}
