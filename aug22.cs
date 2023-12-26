using System;
class aug22{
public static void Main(){
String name = "Dev";
Console.WriteLine("Your output is : "+name);

//insert
String name2 = name.Insert(3,"ansh");
Console.WriteLine("Your output is : "+name2);

//copying
String s1 = string.Copy(name2);
Console.WriteLine("Your output is : "+s1);

//CHecking
Console.WriteLine("Your Output ends with 'sh' ? "+s1.EndsWith("sh"));

int num = 100;
Console.WriteLine(num.GetType());

string num1 = Convert.ToString(num);
Console.WriteLine(num1.GetType());
string num2 = num.ToString();
Console.WriteLine(num2.GetType());

string s3 = "New York";
String s2 = s3.Substring(0);
Console.WriteLine(s2);
}
}