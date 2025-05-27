using System;

public class Enemy
{
    public string Name { get; set; }
    public int Life { get; set; }
    public bool Statos { get; set; }

    public string Shout { get; set; }

    public Enemy(string name)
    {
        this.Name = name;
        this.Life = 100;
        this.Statos = true;
        this.Shout = "I'm an enemy!!!";
    }
}