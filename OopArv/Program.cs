namespace OopArv;

class Program
{
    static void Main(string[] args)
    {
        Alligator myalligator = new Alligator("Allison", "American Alligator");

        Console.WriteLine($"{myalligator.Name}'s tail is {myalligator.TailLength} metres long.");
        Console.WriteLine($"{myalligator.Name}'s crushing power is {myalligator.CrushingPower}.");
        myalligator.Eat();
        myalligator.Sleep();
        myalligator.Move();
        myalligator.makeSound();
        myalligator.Bite();

        Bear mybear = new Bear("Bobby", "Brown Bear");

        Console.WriteLine($"{mybear.Name}'s fur color is {mybear.FurColor}.");
        Console.WriteLine($"{mybear.Name} is {mybear.Cuteness}.");
        mybear.Eat();
        mybear.Sleep();
        mybear.Move();
        mybear.makeSound();
        mybear.Climb();

        Parrot myparrot = new Parrot("Polly", "Amazonian");

        Console.WriteLine($"{myparrot.Name}'s color is {myparrot.Color}.");
        Console.WriteLine($"{myparrot.Name} {myparrot.MimicSpeech}.");
        myparrot.Eat();
        myparrot.Sleep();
        myparrot.Move();
        myparrot.makeSound();
        myparrot.Dance();

        PolarBear mypolarbear = new PolarBear("Sven");

        Console.WriteLine($"{mypolarbear.Name}'s fur color is {mypolarbear.WinterFur}.");
        mypolarbear.makeSound();

        GrizzlyBear mygrizzlybear = new GrizzlyBear("Bamse");

        Console.WriteLine($"{mygrizzlybear.Name}'s weight is {mygrizzlybear.Weight}.");
        mygrizzlybear.makeSound();
    }
}