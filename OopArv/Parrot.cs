namespace OopArv;

public class Parrot : Animal //inherited class from Animal 
{
// a constructor that lets you create many parrots 
    public Parrot(string name = "Lucas", string species = "Tropical Parrot")
    {
        Name = name;
        Species = species;
        Age = 4;
        Behavior = "Chatty";
        Habitat = "Jungle";
    }
    
    //two unique properties 
    public string Color { get; set; } = "Green";
    public string MimicSpeech { get; set; } = "imitates";
    
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
        Console.WriteLine($"{Name} flies");
    }
    public override void makeSound()
    {
        Console.WriteLine($"{Name} whistles");
    }

    
    // one unique method just for this animal 
    public void Dance()
    {
        Console.WriteLine($"{Name} has a dance routine");
    }
}
