using System;

public class CommandosSoldiers
{
    public string name;
    public string codeName;
    public string[] tools = new string[5];
    public string status;

    public CommandosSoldiers(string name, string codeName, string[] tools, string status)
    {
        this.name = name;
        this.codeName = codeName;
        if (tools.Length != 5)
        {

        }
        this.tools = tools;
        this.status = status;
    }

    public void Walk()
    {
        Console.WriteLine("The soldier is walking.");
        status = "Walking";
    }

    public void Hide()
    {
        Console.WriteLine("The soldier is hiding.");
        status = "Hide";
    }

    public void Attack()
    {
        Console.WriteLine($"Soldier {name} attacks");
    }
}