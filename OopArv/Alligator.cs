namespace OopArv;

public class Alligator : Animal //inheritance from Animal 
{
// a constructor that lets you create many alligators 
    public Alligator(string name = "Tommy", string species = "Chinese alligator")
    {
        Name = name;
        Species = species;
        Age = 5;
        Behavior = "Aggressive";
        Habitat = "Swamps";
    }
    
    //two unique properties 
    public float TailLength { get; set; } = 1.5f; 
    public string CrushingPower { get; set; } = "3000 pounds per square inch";
    
    //overriden methods 
    public override void Eat()
    {
        Console.WriteLine($"{Name} eats");
    }
    public override void Sleep()
    {
        Console.WriteLine($"{Name} sleeps");   
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} slithers");
    }
    public override void makeSound()
    {
        Console.WriteLine($"{Name} growls");
    }

    
    // one unique method just for this animal 
    public void Bite()
    {
        Console.WriteLine($"{Name} bites");
    }
}