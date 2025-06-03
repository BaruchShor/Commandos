using System;
using System.Collections.Generic;

public class CommandoFactory
{
    public List<GetSoldiers> CommandoNamesAndType = new List<GetSoldiers>();
    public List<CommandosSoldiers> CommandoList = new List<CommandosSoldiers>();

    public CommandoFactory(List<GetSoldiers> enemyNames, string type)
    {
        this.CommandoNamesAndType = enemyNames;
        CreateCommandoSoldier();
    }

    public void CreateCommandoSoldier()
    {
        foreach (GetSoldiers CommandoName in CommandoNamesAndType)
        {
            switch (CommandoName.Type)
            {
                case "regular":
                    CommandoList.Add(new CommandosSoldiers(CommandoName.Name, CommandoName.CodeName));
                    break;
                case "sea":
                    CommandoList.Add(new SeaCommando(CommandoName.Name, CommandoName.CodeName));
                    break;
                case "air":
                    CommandoList.Add(new AirCommando(CommandoName.Name, CommandoName.CodeName));
                    break;
            }

        }
    }
    
    public void ShowList()
    {
        foreach (CommandosSoldiers commandoObject in CommandoList)
        {
            Console.WriteLine(commandoObject.Name);
        }
    }
}