using System;

class arr2d{
public static void Main(){
	int row = 11;
	int col = 11;
	
	int[,] arr = new int[row,col];



for(int i=1; i<row; i++){
	for(int j=1; j<col; j++){
arr[i,j]=i*j;
	Console.Write(" "+arr[i,j]);
}
Console.WriteLine();

}	
}}