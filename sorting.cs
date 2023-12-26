using System;

public class sorting{
	public static void Main(){
	
		Console.WriteLine("Enter the Size of Array : ");
		String a = Console.ReadLine();
		int n = Convert.ToInt32(a);
			
		int[] arr = new int[n];
//read values
for(int i=0; i<n; i++){
		Console.WriteLine("Enter number : "+i+" Element : ");
		String z = Console.ReadLine();
		arr[i] = Convert.ToInt32(z);
		
}

//Print array
Console.WriteLine("Values of your array is : ");
for(int i1=0; i1<n; i1++){
	Console.Write(arr[i1]+" ");
}
	
	for(int j=0; j<n; j++){
		for(int k=j+1; k<n; k++){
		
		if(arr[j]<arr[k]){
	int temp = arr[j];
	arr[j] = arr[k];
	arr[k] = temp;
}
} 
}
Console.WriteLine();
Console.WriteLine("After sorting......");
for(int i2=0; i2<n; i2++){
	Console.Write(arr[i2]+" ");
}

	
	}
}