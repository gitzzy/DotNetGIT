using System;

class sorting1{
	public static void Main(){
	
int[] arr = {23,60,45,76,98};
int x = arr.Length;
Console.WriteLine("Length of array : "+x);

//printing array element

for(int i=0; i<x; i++){
Console.Write(arr[i]+" ");
}

//sorting begins

for(int j=0; j<x; j++){
	for(int k=j+1; k<x; k++){

if(arr[j]>arr[k]){
		int tmp = arr[j];
		arr[j] = arr[k];
		arr[k] = tmp;
}
}
}
// Sorted array printy
Console.WriteLine();
Console.WriteLine("Sorted array items");

for(int l=0; l<x; l++){

Console.Write(arr[l]+" ");
}

//sorting using method
Array.Sort(arr);
Console.WriteLine();
Console.WriteLine("Sorted array using Method : ");

for(int l1=0; l1<x; l1++){

Console.Write(arr[l1]+" ");
}

//reversing

Array.Reverse(arr);
Console.WriteLine();
Console.WriteLine("reverse method : ");

for(int l2=0; l2<x; l2++){

Console.Write(arr[l2]+" ");
}

}
}