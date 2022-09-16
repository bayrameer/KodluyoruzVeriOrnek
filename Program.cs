using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Cozum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] loto = new int[6];

            Random rastgele = new Random();
            bool varMi = false;

            for (int i = 0; i < 6; i++)
            {
                int sayi = rastgele.Next(1,7);
                for (int j = 0; j < 6; j++)
                {
                    if (sayi == loto[j])
                    {
                        varMi = true;
                        break;
                    }
                }
                if (varMi)
                {
                    i--;
                    varMi = false;

                }
                else
                {
                    loto[i] = sayi;
                }
                  
            }
            foreach (var item in loto)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
