namespace OopArv;

public class Bear : Animal //inherited class from Animal 
{
// a constructor that lets you create many bears
    public Bear(string name = "Sunny", string species = "Brown bear")
    {
        Name = name;
        Species = species;
        Age = 6;
        Behavior = "Cuddly";
        Habitat = "Forest";
    }
    
    //two unique properties 
    public string FurColor { get; set; } = "Dark Brown";
    public string Cuteness { get; set; } = "Extremely cute";
    
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
        Console.WriteLine($"{Name} climbs");
    }
    public override void makeSound()
    {
        Console.WriteLine($"{Name} roars");
    }

    
    // one unique method just for this animal 
    public void Climb()
    {
        Console.WriteLine($"{Name} climbs a tree");
    }
}