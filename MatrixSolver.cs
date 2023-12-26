using System;

class MatrixSolver{
public static void Main(){

Console.WriteLine("Enter the size of Matrix 1 ");
Console.Write("Enter number of rows : ");
string row1 = Console.ReadLine();
int row11 = Convert.ToInt32(row1);


Console.Write("Enter number of columns : ");
string col1 = Console.ReadLine();
int col11 = Convert.ToInt32(col1);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
//Matrix 2
Console.WriteLine("Enter the size of Matrix 2  ");
Console.Write("Enter number of rows : ");
string row2 = Console.ReadLine();
int row22 = Convert.ToInt32(row2);

Console.Write("Enter number of columns : ");
string col2 = Console.ReadLine();
int col22 = Convert.ToInt32(col2);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


int n = row11;
int m = col11;

int[,] Matrix1 = new int[row11,col11];
int[,] Matrix2 = new int[row22,col22];

for(int i=0; i<n; i++){
	for(int j=0; j<m; j++){
Console.WriteLine("Enter Matrix1's Row : "+ i+" , Column : "+j);
string mat1 = Console.ReadLine();
Matrix1[i,j] = Convert.ToInt32(mat1);
}
}
Console.WriteLine();
for(int i=0; i<n; i++){
	for(int j=0; j<m; j++){
Console.WriteLine("Enter Matrix2's Row : "+ i+" , Column : "+j);
string mat2 = Console.ReadLine();
Matrix2[i,j] = Convert.ToInt32(mat2);
}
}


//Printing
Console.WriteLine();
Console.WriteLine();
for(int i=0; i<n; i++){
	for(int j=0; j<m; j++){
Console.Write(Matrix1[i,j]+" ");
}
Console.WriteLine();
}

Console.WriteLine();
for(int i=0; i<n; i++){
	for(int j=0; j<m; j++){
Console.Write(Matrix2[i,j]+" ");
}
Console.WriteLine();
}

if(row11==row22 ){
}

}
}