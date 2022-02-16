using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_gyakorlas_R_Krisztian
{
    class Program
    {
        static void SorozatKiir() 
        {
            Console.Write("Kérem adjon meg egy minumumot ");
            int minimum = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy maximumot");
            int maximum = int.Parse(Console.ReadLine());
            if (minimum >= maximum) 
            {
                Console.WriteLine("Nem külnbözik, vagy nem nagyobb a maximum a minimumnál!");
            }
            else 
            {
            for (int i = minimum; i < maximum; i++)
                        {
                            Console.WriteLine(i + 1);
            }
            }
            
        }

        static void Main(string[] args)
        {
            SorozatKiir();
            Console.ReadKey();
        }
    }
}
