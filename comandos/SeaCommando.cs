using System;


namespace comandos
{
    internal class SeaCommando: Commando
    {
        public string UnitName { get; set; }

        public SeaCommando(string name, string codeName, string status, string unitName) :base(name, codeName, status)
        {
            this.UnitName = unitName;
        }

        public void Swimming()
        {
            Console.WriteLine($"the {CodeName} is Swimming");
            this.Status = "Swimming";
        }

        public override void Attack()
        {
            Console.WriteLine($"the sea commando {CodeName} is attack");
        }

    }
}
