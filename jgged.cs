using System;
class jgged{
	public static void Main(){
		int[][] jArr = new int[3][];
		jArr[0] = new int[1];
		jArr[1] = new int[2];
		jArr[2] = new int[3];
	
	jArr[0][0] = 1;
	jArr[1][0] = 2;
jArr[1][1] = 3;

Console.WriteLine(jArr[0][0]);
Console.WriteLine(jArr[1][1]);
Console.WriteLine(jArr[1][0]);	 
}
}