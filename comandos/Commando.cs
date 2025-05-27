using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandos
{
    internal class Commando
    {
        private string Name;
        public string CodeName { get; set; }
        public string[] Tools = { "hammer", "chisel", "rope", "bag", "water bottle" };
        public string Status;

        public Commando(string name, string codeName, string status)
        {
            this.Name = name;
            this.CodeName = codeName;
            this.Status = status;
        }

        public string SayName(string commanderRank)
        {
            if (commanderRank == "General")
            {
                return Name;
            }
            else if (commanderRank == "Colonel")
            {
                return CodeName;
            }
            else
            {
                Console.WriteLine("you dont heve permision for this intel");
                return "";
            }
        }

        public void Walk()
        {
            Console.WriteLine($"the {CodeName} is walking");
            this.Status = "walking";
        }

        public void Hide()
        {
            Console.WriteLine($"the {CodeName} is hiding");
            this.Status = "hiding";
        }
        
        public void Attack()
        {
            Console.WriteLine($"the {CodeName} is attack");
        }
    }
}
