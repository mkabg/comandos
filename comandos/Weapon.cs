using System;


namespace comandos
{
    internal class Weapon
    {
        public string Name, Manufacturer;
        public int NumAmmo;

        public Weapon(string name, string manufacturer, int numAmmo)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.NumAmmo = numAmmo;
        }

        public void Shoot()
        {
            if (NumAmmo > 0)
            {
                Console.WriteLine("shoting");
                NumAmmo -= 1;
            }
            else
            {
                Console.WriteLine("there is no bullet");
            }
        }

    }
}
