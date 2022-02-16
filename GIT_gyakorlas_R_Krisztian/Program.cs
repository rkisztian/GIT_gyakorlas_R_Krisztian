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
            Console.Write("Kérem adjon meg egy számot ami nagyobb mint egy: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam <= 1) 
            {
                Console.WriteLine("Nem megfelelő számot adott meg");
            }
            else 
            {
            for (int i = 1; i < szam; i++)
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
