using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kółkokrzyżyk
{
    class Program
    {
        static void Zasady()
        {
            Console.WriteLine("Graficznie (np. na kartce) gra najczęściej przebiega następująco: \r\nPole gry to 4 przecinające się " +
                "linie: dwie pionowo i dwie poziomo \r\nNa poszczególnych polach wyznaczonych przez tę figurę gracze stawiają na przemian kółko i krzyżyk. \r\nGdy któryś " +
                "z graczy stworzy linię trzech krzyżyków lub trzech kółek, przekreśla ją i zostaje zwycięzcą. \r\nGdy wszystkie pola są zajęte i nie zostaje utworzona linia, " +
                "gra kończy się remisem. \r\nPrzy odpowiednio dobrze grających graczach zawsze skończy się remisem.\r\n");
            string[] mapa = new string[] { "", "1", "|", "2", "|", "3", "-", "+", "-", "+", "-", "4", "|", "5", "|", "6", "-", "+", "-", "+", "-", "7", "|", "8", "|", "9" };
            for (int i = 1; i <= 25; i++)
            {
                Console.Write(mapa[i]);
                if (i % 5 == 0)
                {
                    Console.Write("\r\n");
                }
            }
        }
        static void Rysuj()
        {
            string[] mapa = new string[] {""," ","|"," ","|"," ","-", "+", "-", "+", "-", " ", "|", " ", "|", " ", "-", "+", "-", "+", "-", " ", "|", " ", "|", " "};
            for (int i = 1; i <= 25; i++)
            {
                Console.Write(mapa[i]);
                if (i % 5 == 0)
                {
                    Console.Write("\r\n");
                }
            }
        }
        static void Main(string[] args)
        {
            string odp = null;
            do
            {
                Console.WriteLine("Witaj w grze w kółko i krzyżyk. \r\nCzy znasz zasady tej gry?");
                odp = Console.ReadLine();
                odp = odp.ToLower();
                if (odp == "nie")
                {
                    Zasady();
                }
            } while (odp != "tak");
            Console.WriteLine("No to zaczynajmy");
            Rysuj();
        }
    }
}
