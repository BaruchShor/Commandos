using System;

public class SeaCommando : CommandosSoldiers
{
    public bool Swimming { get; set; }
    public SeaCommando(string name, string codeName) : base(name, codeName)
    {
    }

    public void isSwimming()
    {
        Console.WriteLine($"The soldier {Name} is falling.");
    }
}