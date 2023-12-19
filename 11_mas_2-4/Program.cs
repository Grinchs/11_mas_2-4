using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4
{
    internal class Program

    {
        static void Main()
        {
            Console.Write("Ievadiet pirmā masīva izmēru: ");
            int izm1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet otrā masīva izmēru: ");
            int izm2 = int.Parse(Console.ReadLine());

            int[] mas1 = new int[izm1];
            int[] mas2 = new int[izm2];

            Random random = new Random();
            for (int i = 0; i < izm1; i++)
            {
                mas1[i] = random.Next(10, 100);
            }

            for (int i = 0; i < izm2; i++)
            {
                mas2[i] = random.Next(10, 100);
            }


            Array.Sort(mas1);
            Array.Sort(mas2);

            Console.WriteLine("Pirmais\t     Otrais");
            for (int i = 0; i < Math.Max(izm1, izm2); i++)
            {
                string vert1 = (i < izm1) ? mas1[i].ToString() : " ";
                string vert2 = (i < izm2) ? mas2[i].ToString() : " ";
                Console.WriteLine($"{vert1}\t\t{vert2}");
            }

            int min1 = mas1[0];
            int max1 = mas1[izm1 - 1];
            int min2 = mas2[0];
            int max2 = mas2[izm2 - 1];


            if (min1 == min2)
            {
                Console.WriteLine($"\nAbos masīvos ir vienāda mazākā vērtība un ir vienāda ar {min1}");
            }
            else
            {
                if (min1 < min2)
                    Console.WriteLine($"\nMazākais skaitlis ir no pirmā masīva un ir vienāds ar {min1}");
                else if (min2 < min1)
                    Console.WriteLine($"\nMazākais skaitlis ir no otra masīva un ir vienāds ar {min2}");
            }

            if (max1 == max2)
            {
                Console.WriteLine($"Abos masīvos ir vienāda lielākā vērtība un ir vienāda ar {max1}");
            }
            else
            {
                if (max1 > max2)
                    Console.WriteLine($"Lielākais skaitlis ir no pirmā masīva un ir vienāds ar {max1}");
                else if (max2 > max1)
                    Console.WriteLine($"Lielākais skaitlis ir no otra masīva un ir vienāds ar {max2}");
            }
        }
    }
}