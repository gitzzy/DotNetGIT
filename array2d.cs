using System;

class array2d{
	public static void Main(){
	int[,]  arr2d = new int[2,2];
	
	//initialization
	arr2d[0,0] = 10;
	arr2d[0,1] = 11;
	arr2d[1,0] = 12;
	arr2d[1,1] = 13;


//Prionting array
for(int i=0; i<2; i++){
	for(int j=0; j<2; j++){
	Console.Write(arr2d[i,j]+" ");	
}
Console.WriteLine();
}
}
}