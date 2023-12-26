using System;

public abstract class Base{

public abstract void Sound();
public virtual void Action(){
Console.WriteLine("Action ..");
}
}

class Cat:Base{
public override void  Sound(){
Console.WriteLine("Meow! Meow!");
}

public override void Action(){
Console.WriteLine("Cat is Yarning");
}
}

class Dog:Base{
public override void Sound(){
Console.WriteLine("Woof! Woof!");
}

public override void Action(){
Console.WriteLine("Dog is Barking");
}
}

class Abstrct{
public static void Main(){

Cat c1 = new Cat();
c1.Sound();
c1.Action();

Dog d1 = new Dog();
d1.Sound();
d1.Action();
}
}
