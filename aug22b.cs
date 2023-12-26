using System;
using System.Text;

class aug22b{
public static void Main(){
StringBuilder s1 = new StringBuilder("Raw data");
Console.WriteLine("Phase 1 : ");
Console.WriteLine("Original text    : "+s1);
Console.WriteLine("Capacity of Text : "+s1.Capacity);
Console.WriteLine("Length of Text   : "+s1.Length);
Console.WriteLine("Max Capacity     : "+s1.MaxCapacity);
Console.WriteLine();

//Append : adds data
s1.Append(" (used)");
Console.WriteLine("Phase 2 : ");
Console.WriteLine("Original text    : "+s1);
Console.WriteLine("Capacity of Text : "+s1.Capacity);
Console.WriteLine("Length of Text   : "+s1.Length);
Console.WriteLine();

//AppendFormat
string name = "Devansh";
string nat = "Indian";
StringBuilder s2 = new StringBuilder();
s2.AppendFormat("My name is {0} and i am an {1}.",name,nat);
Console.WriteLine(s2);
Console.WriteLine();

//Insert
s1.Insert(3," 3rd Hand");
Console.WriteLine("Phase 3 : ");
Console.WriteLine("Original text    : "+s1);
Console.WriteLine();

//Remove
s1.Remove(3,4);
Console.WriteLine("Phase 4 : ");
Console.WriteLine("Original text    : "+s1);
Console.WriteLine();

//Replace
s2.Replace("Indian","Hindu");
Console.WriteLine(s2);


}
}
