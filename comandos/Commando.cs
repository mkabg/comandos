using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandos
{
    internal class Commando
    {
        public string Name, CodeName;
        public string[] Tools;
        public string Status;

        public Commando(string name, string codeName, string[] tools, string status)
        {
            this.Name = name;
            this.CodeName = codeName;
            this.Tools = tools;
            this.Status = status;
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
