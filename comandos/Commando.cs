using System;


namespace comandos
{
    internal class Commando
    {
        protected string Name;
        public string CodeName { get; set; }
        public string[] Tools = { "hammer", "chisel", "rope", "bag", "water bottle" };
        public string Status;

        public Commando(string name, string codeName, string status)
        {
            this.Name = name;
            this.CodeName = codeName;
            this.Status = status;
        }

        public string SayName(string rank)
        {
            return Permissions.SayName(rank, Name, CodeName);
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
        
        public virtual void Attack()
        {
            Console.WriteLine($"the {CodeName} is attack");
        }
    }
}
