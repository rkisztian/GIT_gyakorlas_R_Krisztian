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
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            SorozatKiir();
            Console.ReadKey();
        }
    }
}
