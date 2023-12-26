using System;
using System.Collections;

class arrlist{
	static void Main(){
	ArrayList a = new ArrayList();
	a.Add("Delhi");
	a.Add("India");
	a.Add("Deutchland");
	a.Add("USA");
	a.Add("Sonipat");

ArrayList b = new ArrayList();

a.CopyTo(b.ToArray());

Console.WriteLine("After using Add : ");
Console.WriteLine();
int x = a.Count;

for(int i=0; i<x; i++){
	Console.WriteLine(a[i]+" ");
	}
	Console.WriteLine();Console.WriteLine();
	Console.WriteLine("Capacity : "+a.Capacity);
	Console.WriteLine("Count : "+a.Count);

Console.WriteLine();Console.WriteLine();Console.WriteLine();
Console.WriteLine("After using Clear()");
a.Clear();
Console.WriteLine("Capacity : "+a.Capacity);
	Console.WriteLine("Count : "+a.Count);

Console.WriteLine();Console.WriteLine();Console.WriteLine();
Console.WriteLine("Element in ArrayList 'b' after using CopyTo() ");
Console.WriteLine();
for(int i1=0; i1<x; i1++){
	Console.WriteLine(b[i1]+" ");
	}
	Console.WriteLine();Console.WriteLine();
	Console.WriteLine("Capacity : "+b.Capacity);
	Console.WriteLine("Count : "+b.Count);
	}
}