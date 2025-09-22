using System;

abstract class Dessert
{
    // Common steps
    public void AddSugar()
    {
        Console.WriteLine("Step: Add Sugar");
    }

    public void Serve()
    {
        Console.WriteLine("Step: Serve to the Customer");
    }

    // Abstract method (varies depending on dessert type)
    public abstract void Prepare();
}

class IceCream : Dessert
{
    public override void Prepare()
    {
        Console.WriteLine("Step: Blend the mixture, churn it, and keep in the freezer.");
    }
}

class Cake : Dessert
{
    public override void Prepare()
    {
        Console.WriteLine("Step: Mix the batter and bake it in the oven until fluffy.");
    }
}

class GulabJamun : Dessert
{
    public override void Prepare()
    {
        Console.WriteLine("Step: Roll dough into balls, fry them, and dip in sugar syrup.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Preparing IceCream:");
        Dessert d1 = new IceCream();
        d1.AddSugar();
        d1.Prepare();
        d1.Serve();

        Console.WriteLine();

        Console.WriteLine("Preparing Cake:");
        Dessert d2 = new Cake();
        d2.AddSugar();
        d2.Prepare();
        d2.Serve();

        Console.WriteLine();

        Console.WriteLine("Preparing Gulab Jamun:");
        Dessert d3 = new GulabJamun();
        d3.AddSugar();
        d3.Prepare();
        d3.Serve();
    }
}
