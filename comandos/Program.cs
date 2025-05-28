using System;


namespace comandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando c1 = CreateCommando.Create("army", "mordecahi", "ABG", "stand", "Artillery");

            Commando ac1 = CreateCommando.Create("air", "yakov", "1", "stand", "669");

            Commando sc1 = CreateCommando.Create("sea", "avi", "123", "stand", "Shayetet 13");

            Weapon w1 = new Weapon("M16", "Colt", 22);

            ////stage 1
            //c1.Walk();
            //Console.WriteLine(c1.Status);
            //Console.WriteLine(w1.NumAmmo);
            //w1.Shoot();
            //Console.WriteLine(w1.NumAmmo);
            //Console.WriteLine(w1.Name);

            ////stage 2
            //Console.WriteLine(c1.SayName("General"));
            //Console.WriteLine(c1.SayName("Colonel"));
            //Console.WriteLine(c1.SayName("Colone"));
            //c1.CodeName = "B&H";
            //Console.WriteLine(c1.CodeName);

            ////stage 3
            //Console.WriteLine(ac1.CodeName);
            //Console.WriteLine(ac1.Status);
            //ac1.Parachuting();
            //Console.WriteLine(ac1.Status);
            //Console.WriteLine(sc1.Status);
            //sc1.Swimming();
            //Console.WriteLine(sc1.Status);

            //stage 4
            Commando[] commandos = new Commando[] { c1, ac1, sc1 };
            sc1.Walk();
            foreach (Commando c in commandos)
            {
                c.SayName("General");
                c.Attack();
            }
        }
    }
}
