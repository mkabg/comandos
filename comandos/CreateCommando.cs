

namespace comandos
{
    internal class CreateCommando
    {
        public static Commando Create(string type , string name, string codeName, string status, string unitName)
        {
            switch (type)
            {
                case "air":
                    return new AirCommando(name, codeName, status, unitName);

                case "sea":
                    return new SeaCommando(name, codeName, status, unitName);

                case "army":
                    return new ArmyCommando(name, codeName, status, unitName);

                default:
                    return null;
            }
        }
    }
}
