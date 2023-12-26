using System;

class Sort{
public static void Main(string[] args){

int[] marks = {100,56,78,96,32};

Console.WriteLine("Before ");
foreach(int i in marks){
Console.Write(i+" ");
}
Console.WriteLine();

//sorting

for(int i=0; i<5; i++){
	for(int j=i+1; j<5; j++){
if(marks[i]<marks[j]){
	int temp = marks[i];
	marks[i] = marks[j];
	marks[j] = marks[i];
	
	
}
}
} 
//end
Console.WriteLine("After ");
foreach(int i in marks){
Console.Write(i+" ");
}
Console.WriteLine();
}
}