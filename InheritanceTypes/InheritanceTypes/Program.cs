using System;
using InheritanceTypes.SingleInheritance;
using InheritanceTypes.MultilevelInheritance;
using InheritanceTypes.HierarchicalInheritance;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Single Inheritance ===");
        InheritanceTypes.SingleInheritance.Dog singleDog = new InheritanceTypes.SingleInheritance.Dog();
        singleDog.Eat();
        singleDog.Bark();

        Console.WriteLine("\n=== Multilevel Inheritance ===");
        InheritanceTypes.MultilevelInheritance.Dog multiDog = new InheritanceTypes.MultilevelInheritance.Dog();
        multiDog.Eat();
        multiDog.Walk();
        multiDog.Bark();

        Console.WriteLine("\n=== Hierarchical Inheritance ===");
        InheritanceTypes.HierarchicalInheritance.Dog hierDog = new InheritanceTypes.HierarchicalInheritance.Dog();
        hierDog.Eat();
        hierDog.Bark();

        InheritanceTypes.HierarchicalInheritance.Cat hierCat = new InheritanceTypes.HierarchicalInheritance.Cat();
        hierCat.Eat();
        hierCat.Meow();


    }
}
