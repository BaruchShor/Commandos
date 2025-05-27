using System;
using System.Collections.Generic;

public class EnemyFactory
{
    public List<string> EnemyNames = new List<string>();
    public List<Enemy> EnemyList = new List<Enemy>();

    public EnemyFactory(List<string> enemyNames)
    {
        this.EnemyNames = enemyNames;
        CreateEnamy();
    }
    public void CreateEnamy()
    {
        foreach(string enemyName in EnemyNames)
        {
            EnemyList.Add(new Enemy(enemyName));
        }
    }

    public void ShowList()
    {
        foreach (Enemy enemyObject in EnemyList)
        {
            Console.WriteLine(enemyObject.Name);
        }
    }
}