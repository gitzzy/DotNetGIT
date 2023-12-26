using System;

class Base{

public virtual void Paint(){
Console.WriteLine("Painting ..");
}
}

class Circle : Base {

public override void Paint(){
Console.WriteLine("Painting Circle");
}

}

class Virtual{
public static void Main(){

Base obj = new Base();
Circle obj1 = new Circle();
obj.Paint();
obj1.Paint();

}
}
