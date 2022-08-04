

using System;  
   public class Animal
{
    public void eat()
    {
        Console.WriteLine("Eating...");
    }
}
public class Dog : Animal
{
    public void run()
    {
        Console.WriteLine("Running...");
    }
}
public class Cat : Animal, Dog
{
    public void sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}
class TestInheritance2
{
    public static void Main(string[] args)
    {
        Dog d1 = new Dog();
        d1.eat();
        d1.run();

        Cat c1 = new Cat();
        c1.eat();
        c1.sleep();
        Console.ReadLine();
    }
}
