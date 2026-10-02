namespace OopArv;

public class GrizzlyBear : Bear
{
    // Pass the chosen name and species to Bear's constructor.
    public GrizzlyBear(string name = "Grizzly")
        : base(name, "Grizzly bear")
    {
    }

    public string Weight { get; set; } = "100kg";

    public override void makeSound()
    {
        Console.WriteLine($"{Name} huffs");
    }
}