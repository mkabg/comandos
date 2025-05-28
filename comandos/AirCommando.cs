using System;


namespace comandos
{
    internal class AirCommando : Commando
    {
        
        public string UnitName { get; set; }

        public AirCommando(string name, string codeName, string status, string unitName) :base(name, codeName, status)
        {
            this.UnitName = unitName;
        }

        public void Parachuting()
        {
            Console.WriteLine($"the {CodeName} is parachuting");
            this.Status = "parachuting";
        }

        public override void Attack()
        {
            Console.WriteLine($"the air commando {CodeName} is attack");
        }
    }
}
