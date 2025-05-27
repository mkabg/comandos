using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandos
{
    internal class AirCommando : Commando
    {
        
        private string UnitName;

        public AirCommando(string name, string codeName, string status, string unitName) :base(name, codeName, status)
        {
            this.UnitName = unitName;
        }

        public void Parachuting()
        {
            Console.WriteLine($"the {CodeName} is parachuting");
            this.Status = "parachuting";
        }
    }
}
