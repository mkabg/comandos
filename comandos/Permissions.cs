using System;


namespace comandos
{
    internal class Permissions
    {
        public  static string SayName(string commanderRank, string name, string codeName)
        {
            if (commanderRank == "General")
            {
                return name;
            }
            else if (commanderRank == "Colonel")
            {
                return codeName;
            }
            else
            {
                Console.WriteLine("you dont heve permision for this intel");
                return "";
            }
        }
    }
}
