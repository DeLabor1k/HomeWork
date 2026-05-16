using System;

public class Animal
{
    public string Name;

    public Animal(string name)
    {
        Name = name;
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public void Meow()
    {
        Console.WriteLine("Meow!");
    }
}
class Program
{
    static void Main()
    {
        // Просто для компиляции
        System.Console.WriteLine("Код выполнен");
    }
}