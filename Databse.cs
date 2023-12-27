using System;
using MySql.Data.MySqlClient;

class Databse{
public static void Main(){

String Addrs = "Server=localhost;Database=JavaDB;User ID=root; Password=;";
try{
MySqlConnection con = new MySqlConnection(Addrs);
con.Open();
Console.WriteLine("Connection Established");
con.Close();
Console.WriteLine("Connection Terminated");
}
catch(Exception e){
Console.WriteLine(e.Message);
}

}
}
