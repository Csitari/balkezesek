using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace balkezesek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] lines = File.ReadAllLines("balkezesek.txt");

            balkezxd[] players = new balkezxd[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                if (parts.Length == 5)
                {
                    string playerName = parts[0];
                    string firstAppearance = parts[1];
                    string lastAppearance = parts[2];
                    int playerWeight = int.Parse(parts[3]);
                    int playerHeight = int.Parse(parts[4]);

                    players[i] = new balkezxd(playerName, firstAppearance, lastAppearance, playerWeight, playerHeight);
                }
            }

            Console.WriteLine($"3. feladat: {lines.Length}");

            Console.WriteLine("4.feladat:");
            foreach (var player in players)
            {
                if (player != null && player.lastA.Contains("1999-10"))
                {
                    double heightInCm = player.height * 2.54;
                    Console.WriteLine($"\t{player.playa}, {heightInCm:F1} cm");
                }
            }

            Console.WriteLine("5.feladat:");
            int selectedYear = 1990;
            bool validYear = false;

            Console.Write("Kérem adjon meg egy 1990 és 1999 közötti évszámot: ");
            while (!validYear)
            {
                
                if (int.TryParse(Console.ReadLine(), out selectedYear) && selectedYear >= 1990 && selectedYear <= 1999)
                {
                    validYear = true;
                }
                else
                {
                    
                    Console.Write("Hibás adat! Kérek egy 1990 és 1999 közötti évszámot!:");
                }
            }


            Console.Write("6. feladat: ");
            double averageWeight = 0;
            int playerCount = 0;

            foreach (var player in players)
            {
                if (player != null && player.lastA.Contains(selectedYear.ToString()))
                {
                    averageWeight += player.weight;
                    playerCount++;
                }
            }

            if (playerCount > 0)
            {
                averageWeight /= playerCount;
                Console.WriteLine($"{averageWeight:F2} font");
            }
            else
            {
                Console.WriteLine($"Nincsenek adatok az {selectedYear}. év játékosairól.");
            }

            Console.ReadKey();
        }
    }
}
