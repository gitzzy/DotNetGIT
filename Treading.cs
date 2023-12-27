using System;
using System.Threading;

class Treading{
public static void Main(){

Thread t1 = new Thread(Count);
Console.WriteLine("Loading....");
t1.Start();
t1.Join();
Console.WriteLine();
Console.WriteLine("Loading is Completed.");
}
public static void Count(){
for(int i=0; i<=100; i++){
Console.Write("#");
Thread.Sleep(50);
}
}

}
