namespace OopArv;

public class PolarBear : Bear
{
    // Pass the name and species to Bear's constructor.
    public PolarBear(string name = "Snow")
        : base(name, "Polar bear")
    {
        FurColor = "White";
        Habitat = "Arctic";
    }

    public string WinterFur { get; set; } = "White";

    public override void makeSound()
    {
        Console.WriteLine($"{Name} growls");
    }
}
