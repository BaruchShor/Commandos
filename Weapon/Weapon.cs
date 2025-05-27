using System;

public class Weapon
{
    public string name;
    public string manufacturer;
    public int numberOfBalls;

    public Weapon(string name, string manufacturer, int numberOfBalls)
    {
        this.name = name;
        this.manufacturer = manufacturer;
        this.numberOfBalls = numberOfBalls;
    }

    public void Shoot()
    {
        Console.WriteLine("Boom");
        numberOfBalls -= 1;
    }
}