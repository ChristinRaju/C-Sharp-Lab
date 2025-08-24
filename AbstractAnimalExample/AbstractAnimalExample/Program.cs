namespace AbstractAnimalExample
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            myDog.MakeSound(); // Outputs: Woof!
            Animal myCat = new Cat();
            myCat.MakeSound(); // Outputs: Meow!
        }
    }
    public abstract class Animal
    {
        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}