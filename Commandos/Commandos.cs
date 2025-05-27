using System;

public class CommandosSoldiers
{
    public string Name { get; set; }
    public string CodeName { get; set; }
    public string[] Tools = new string[5];
    public string Status;

    public CommandosSoldiers(string name, string codeName)
    {
        this.Name = name;
        this.CodeName = codeName;
        this.Tools = new string[] { "Hammer", "Chisel", "Rope", "Watery", "Bag" };
        this.Status = "Standing";
    }

    public string SayName(string commanderRank)
    {
        if(commanderRank == "General")
        {
            return Name;
        }else if(commanderRank == "Colonel")
        {
            return CodeName;
        }
        return "No access to data";
    }

    public void Walk()
    {
        Console.WriteLine("The soldier is walking.");
        Status = "Walking";
    }

    public void Hide()
    {
        Console.WriteLine("The soldier is hiding.");
        Status = "Hide";
    }

    public virtual void Attack()
    {
        Console.WriteLine($"Soldier {Name} attacks");
    }
}