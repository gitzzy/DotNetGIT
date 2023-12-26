using System;

class Parray{

	static void Parram(params int[] arr){
Console.Write("Array elements are  : ");
			foreach(int i in arr){
		
		Console.Write(i+" ");
		
				}
			Console.WriteLine();
			}

	public static void Main(){
	int[] A = {10,30,50,20};

	Parram(A);
Parram(3040,432,6,5,24,23);
Parram();
	}
}