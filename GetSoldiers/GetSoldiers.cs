using System;

public class GetSoldiers
{
    public string Name { get; set; }
    public string CodeName { get; set; }
    public string Type { get; set; }

    public GetSoldiers(string name, string codeName, string type)
    {
        this.Name = name;
        this.CodeName = codeName;
        this.Type = type;
    }

}