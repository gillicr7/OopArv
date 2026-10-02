namespace OopArv;

public abstract class Animal //base class 
{
    //Properties 
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    public string Behavior { get; set; }
    public string Habitat { get; set; }

    //Methods 
    public virtual void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }

    public virtual void Sleep()
    {
        Console.WriteLine("The animal is sleeping.");
    }

    public abstract void Move();

    public abstract void makeSound();
}