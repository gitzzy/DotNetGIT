using System;

delegate void MD();

class Sub{
static public void Dis(){
	Console.WriteLine("Display Method");
}
static public void Prin(){
	Console.WriteLine("Print Method");
}
}

class MulDelegate{
public static void Main(){
	
	MD m1 = new MD(Sub.Dis);
	MD m2 = new MD(Sub.Prin);

	MD m3 = m1+m2;
	MD m4 = m2;
m3();
m4();

}
}