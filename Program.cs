using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandosSoldiers regularSoldier = new CommandosSoldiers("Hershi", "Golani");
            SeaCommando seaSoldier = new SeaCommando("Baruch", "Shayetet");
            AirCommando airSoldier = new AirCommando("Baruch", "Tzanchanim");
            CommandosSoldiers[] soldiersArray = new CommandosSoldiers[3];
            soldiersArray = new CommandosSoldiers[] { regularSoldier, seaSoldier, airSoldier };
            foreach(CommandosSoldiers soldier in soldiersArray)
            {
                soldier.Attack();
            }
        }
    }
}
