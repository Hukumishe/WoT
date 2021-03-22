using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                Tank[] winner = new Tank[5];
                Tank[] T34 = new Tank[5];
                Tank[] Panther = new Tank[5];

                for (int i = 0; i < 5; i++)
                {
                    T34[i] = new Tank("T34", rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
                }

                for (int i = 0; i < 5; i++)
                {
                    Panther[i] = new Tank("Panther", rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
                }

                for (int i = 0; i < 5; i++)
                {
                    winner[i] = T34[i] * Panther[i];
                    Console.WriteLine(winner[i].ShowInfo());
                }
            }


            catch (Exception e)
            {
                throw e;
            }

            
        }
    }
}
