using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoT
{
    class Tank
    {
        public string Name { get; set; }
        public int AmmunitonLvl { get; set; }
        public int ArmorLvl { get; set; }
        public int ManeuverabilityLvl { get; set; }

        public Tank(string Name,int AmmunitonLvl, int ArmorLvl, int ManeuverabilityLvl)
        {
            //Random rnd = new Random();
            //AmmunitonLvl = rnd.Next(1, 100);
            //ArmorLvl = rnd.Next(1, 100);
            //ManeuverabilityLvl = rnd.Next(1, 100);

            this.Name = Name;
            this.AmmunitonLvl = AmmunitonLvl;
            this.ArmorLvl = ArmorLvl;
            this.ManeuverabilityLvl = ManeuverabilityLvl;
        }

        public Tank()
        {
            Name = "null";
            AmmunitonLvl = 0;
            ArmorLvl = 0;
            ManeuverabilityLvl = 0;
        }

        public static Tank operator *(Tank T34, Tank Panther)
        {
            if (T34.AmmunitonLvl > Panther.AmmunitonLvl && T34.ArmorLvl > Panther.ArmorLvl)
            {
                return T34;
            }
            if (T34.AmmunitonLvl > Panther.AmmunitonLvl && T34.ManeuverabilityLvl > Panther.ManeuverabilityLvl)
            {
                return T34;
            }
            if (T34.ArmorLvl > Panther.ArmorLvl && T34.ManeuverabilityLvl > Panther.ManeuverabilityLvl)
            {
                return T34;
            }
            else
            {
                return Panther;
            }
        }

        public string ShowInfo()
        {
            int sum = AmmunitonLvl + ArmorLvl + ManeuverabilityLvl;
            Console.WriteLine("Победивший танк: " + Name);
            Console.WriteLine("Размер боекомплекта: " + AmmunitonLvl);
            Console.WriteLine("Уровень брони: " + ArmorLvl);
            Console.WriteLine("Уровень маневренности: " + ManeuverabilityLvl);
            Console.WriteLine("Суммарный уровень: " + sum);
            Console.WriteLine("-----------------------------------");

            return "";
        }


    }
}
