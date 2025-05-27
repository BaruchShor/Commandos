using System;

public class AirCommando : CommandosSoldiers
{
    public bool Falling { get; set; }
    public AirCommando(string name, string codeName) : base(name,codeName)
    {
    }

    public void isFalling()
    {
        Console.WriteLine($"The soldier {Name} is falling.");
    }
}