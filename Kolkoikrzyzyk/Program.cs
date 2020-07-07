﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kółkokrzyżyk
{
    class Program
    {
        public string[] mapa = new string[] { "", " ", "|", " ", "|", " ", "-", "+", "-", "+", "-", " ", "|", " ", "|", " ", "-", "+", "-", "+", "-", " ", "|", " ", "|", " " };
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
            string[] mapa = { "", " ", "|", " ", "|", " ", "-", "+", "-", "+", "-", " ", "|", " ", "|", " ", "-", "+", "-", "+", "-", " ", "|", " ", "|", " " };
            for (int i = 1; i <= 25; i++)
            {
                Console.Write(mapa[i]);
                if (i % 5 == 0)
                {
                    Console.Write("\r\n");
                }
            }
        }
        static void Gra()
        {
            string[] mapa = { "", " ", "|", " ", "|", " ", "-", "+", "-", "+", "-", " ", "|", " ", "|", " ", "-", "+", "-", "+", "-", " ", "|", " ", "|", " " };
            bool wygrana = false;
            int wybor;

            do
            {
                wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        if (mapa[1] == " ")
                        {
                            mapa[1] = "X";
                            Random rnd = new Random();
                            int komp = rnd.Next(1, 10);
                            if (komp == 1 && mapa[1] == " ")
                            {
                                mapa[1] = "O";
                            }
                            else if (komp == 2 && mapa[3] == " ")
                            {
                                mapa[3] = "O";
                            }
                            else if (komp == 3 && mapa[5] == " ")
                            {
                                mapa[5] = "O";
                            }
                            else if (komp == 4 && mapa[11] == " ")
                            {
                                mapa[11] = "O";
                            }
                            else if (komp == 5 && mapa[13] == " ")
                            {
                                mapa[13] = "O";
                            }
                            else if (komp == 6 && mapa[15] == " ")
                            {
                                mapa[15] = "O";
                            }
                            else if (komp == 7 && mapa[21] == " ")
                            {
                                mapa[21] = "O";
                            }
                            else if (komp == 8 && mapa[23] == " ")
                            {
                                mapa[23] = "O";
                            }
                            else if (komp == 9 && mapa[25] == " ")
                            {
                                mapa[25] = "O";
                            }
                        }
                        break;
                    case 2:
                        if (mapa[3] == " ")
                        {
                            mapa[3] = "X";
                            Random rnd = new Random();
                            int komp = rnd.Next(1, 10);
                            if (komp == 1 && mapa[1] == " ")
                            {
                                mapa[1] = "O";
                            }
                            else if (komp == 2 && mapa[3] == " ")
                            {
                                mapa[3] = "O";
                            }
                            else if (komp == 3 && mapa[5] == " ")
                            {
                                mapa[5] = "O";
                            }
                            else if (komp == 4 && mapa[11] == " ")
                            {
                                mapa[11] = "O";
                            }
                            else if (komp == 5 && mapa[13] == " ")
                            {
                                mapa[13] = "O";
                            }
                            else if (komp == 6 && mapa[15] == " ")
                            {
                                mapa[15] = "O";
                            }
                            else if (komp == 7 && mapa[21] == " ")
                            {
                                mapa[21] = "O";
                            }
                            else if (komp == 8 && mapa[23] == " ")
                            {
                                mapa[23] = "O";
                            }
                            else if (komp == 9 && mapa[25] == " ")
                            {
                                mapa[25] = "O";
                            }
                        }
                        break;
                    case 3:
                        if (mapa[5] == " ")
                        {
                            mapa[5] = "X";
                            Random rnd = new Random();
                            int komp = rnd.Next(1, 10);
                            if (komp == 1 && mapa[1] == " ")
                            {
                                mapa[1] = "O";
                            }
                            else if (komp == 2 && mapa[3] == " ")
                            {
                                mapa[3] = "O";
                            }
                            else if (komp == 3 && mapa[5] == " ")
                            {
                                mapa[5] = "O";
                            }
                            else if (komp == 4 && mapa[11] == " ")
                            {
                                mapa[11] = "O";
                            }
                            else if (komp == 5 && mapa[13] == " ")
                            {
                                mapa[13] = "O";
                            }
                            else if (komp == 6 && mapa[15] == " ")
                            {
                                mapa[15] = "O";
                            }
                            else if (komp == 7 && mapa[21] == " ")
                            {
                                mapa[21] = "O";
                            }
                            else if (komp == 8 && mapa[23] == " ")
                            {
                                mapa[23] = "O";
                            }
                            else if (komp == 9 && mapa[25] == " ")
                            {
                                mapa[25] = "O";
                            }
                        }
                        break;
                    case 4:
                        if (mapa[11] == " ")
                        {
                            mapa[11] = "X";
                            Random rnd = new Random();
                            int komp = rnd.Next(1, 10);
                            if (komp == 1 && mapa[1] == " ")
                            {
                                mapa[1] = "O";
                            }
                            else if (komp == 2 && mapa[3] == " ")
                            {
                                mapa[3] = "O";
                            }
                            else if (komp == 3 && mapa[5] == " ")
                            {
                                mapa[5] = "O";
                            }
                            else if (komp == 4 && mapa[11] == " ")
                            {
                                mapa[11] = "O";
                            }
                            else if (komp == 5 && mapa[13] == " ")
                            {
                                mapa[13] = "O";
                            }
                            else if (komp == 6 && mapa[15] == " ")
                            {
                                mapa[15] = "O";
                            }
                            else if (komp == 7 && mapa[21] == " ")
                            {
                                mapa[21] = "O";
                            }
                            else if (komp == 8 && mapa[23] == " ")
                            {
                                mapa[23] = "O";
                            }
                            else if (komp == 9 && mapa[25] == " ")
                            {
                                mapa[25] = "O";
                            }
                        }
                        break;
                    case 5:
                        if (mapa[13] == " ")
                        {
                            mapa[13] = "X";
                            Random rnd = new Random();
                            int komp = rnd.Next(1, 10);
                            if (komp == 1 && mapa[1] == " ")
                            {
                                mapa[1] = "O";
                            }
                            else if (komp == 2 && mapa[3] == " ")
                            {
                                mapa[3] = "O";
                            }
                            else if (komp == 3 && mapa[5] == " ")
                            {
                                mapa[5] = "O";
                            }
                            else if (komp == 4 && mapa[11] == " ")
                            {
                                mapa[11] = "O";
                            }
                            else if (komp == 5 && mapa[13] == " ")
                            {
                                mapa[13] = "O";
                            }
                            else if (komp == 6 && mapa[15] == " ")
                            {
                                mapa[15] = "O";
                            }
                            else if (komp == 7 && mapa[21] == " ")
                            {
                                mapa[21] = "O";
                            }
                            else if (komp == 8 && mapa[23] == " ")
                            {
                                mapa[23] = "O";
                            }
                            else if (komp == 9 && mapa[25] == " ")
                            {
                                mapa[25] = "O";
                            }
                        }
                        break;
                    case 6:
                        if (mapa[15] == " ")
                        {
                            mapa[15] = "X";
                            Random rnd = new Random();
                            int komp = rnd.Next(1, 10);
                            if (komp == 1 && mapa[1] == " ")
                            {
                                mapa[1] = "O";
                            }
                            else if (komp == 2 && mapa[3] == " ")
                            {
                                mapa[3] = "O";
                            }
                            else if (komp == 3 && mapa[5] == " ")
                            {
                                mapa[5] = "O";
                            }
                            else if (komp == 4 && mapa[11] == " ")
                            {
                                mapa[11] = "O";
                            }
                            else if (komp == 5 && mapa[13] == " ")
                            {
                                mapa[13] = "O";
                            }
                            else if (komp == 6 && mapa[15] == " ")
                            {
                                mapa[15] = "O";
                            }
                            else if (komp == 7 && mapa[21] == " ")
                            {
                                mapa[21] = "O";
                            }
                            else if (komp == 8 && mapa[23] == " ")
                            {
                                mapa[23] = "O";
                            }
                            else if (komp == 9 && mapa[25] == " ")
                            {
                                mapa[25] = "O";
                            }
                        }
                        break;
                    case 7:
                        if (mapa[21] == " ")
                        {
                            mapa[21] = "X";
                            Random rnd = new Random();
                            int komp = rnd.Next(1, 10);
                            if (komp == 1 && mapa[1] == " ")
                            {
                                mapa[1] = "O";
                            }
                            else if (komp == 2 && mapa[3] == " ")
                            {
                                mapa[3] = "O";
                            }
                            else if (komp == 3 && mapa[5] == " ")
                            {
                                mapa[5] = "O";
                            }
                            else if (komp == 4 && mapa[11] == " ")
                            {
                                mapa[11] = "O";
                            }
                            else if (komp == 5 && mapa[13] == " ")
                            {
                                mapa[13] = "O";
                            }
                            else if (komp == 6 && mapa[15] == " ")
                            {
                                mapa[15] = "O";
                            }
                            else if (komp == 7 && mapa[21] == " ")
                            {
                                mapa[21] = "O";
                            }
                            else if (komp == 8 && mapa[23] == " ")
                            {
                                mapa[23] = "O";
                            }
                            else if (komp == 9 && mapa[25] == " ")
                            {
                                mapa[25] = "O";
                            }
                        }
                        break;
                    case 8:
                        if (mapa[23] == " ")
                        {
                            mapa[23] = "X";
                            Random rnd = new Random();
                            int komp = rnd.Next(1, 10);
                            if (komp == 1 && mapa[1] == " ")
                            {
                                mapa[1] = "O";
                            }
                            else if (komp == 2 && mapa[3] == " ")
                            {
                                mapa[3] = "O";
                            }
                            else if (komp == 3 && mapa[5] == " ")
                            {
                                mapa[5] = "O";
                            }
                            else if (komp == 4 && mapa[11] == " ")
                            {
                                mapa[11] = "O";
                            }
                            else if (komp == 5 && mapa[13] == " ")
                            {
                                mapa[13] = "O";
                            }
                            else if (komp == 6 && mapa[15] == " ")
                            {
                                mapa[15] = "O";
                            }
                            else if (komp == 7 && mapa[21] == " ")
                            {
                                mapa[21] = "O";
                            }
                            else if (komp == 8 && mapa[23] == " ")
                            {
                                mapa[23] = "O";
                            }
                            else if (komp == 9 && mapa[25] == " ")
                            {
                                mapa[25] = "O";
                            }
                        }
                        break;
                    case 9:
                        if (mapa[25] == " ")
                        {
                            mapa[25] = "X";
                            Random rnd = new Random();
                            int komp = rnd.Next(1, 10);
                            if (komp == 1 && mapa[1] == " ")
                            {
                                mapa[1] = "O";
                            }
                            else if (komp == 2 && mapa[3] == " ")
                            {
                                mapa[3] = "O";
                            }
                            else if (komp == 3 && mapa[5] == " ")
                            {
                                mapa[5] = "O";
                            }
                            else if (komp == 4 && mapa[11] == " ")
                            {
                                mapa[11] = "O";
                            }
                            else if (komp == 5 && mapa[13] == " ")
                            {
                                mapa[13] = "O";
                            }
                            else if (komp == 6 && mapa[15] == " ")
                            {
                                mapa[15] = "O";
                            }
                            else if (komp == 7 && mapa[21] == " ")
                            {
                                mapa[21] = "O";
                            }
                            else if (komp == 8 && mapa[23] == " ")
                            {
                                mapa[23] = "O";
                            }
                            else if (komp == 9 && mapa[25] == " ")
                            {
                                mapa[25] = "O";
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                for (int i = 1; i <= 25; i++)
                {
                    Console.Write(mapa[i]);
                    if (i % 5 == 0)
                    {
                        Console.Write("\r\n");
                    }
                }
                if(mapa[1] != " " && mapa[3] != " " && mapa[5] != " " && mapa[11] != " " && mapa[13] != " " && mapa[15] != " " && mapa[21] != " " && mapa[23] != " " && mapa[25] != " ")
                {
                    Console.WriteLine("Remis");
                    wygrana = true;
                }
            } while (wygrana == true);
        }
        static void Znow()
        {
            Console.WriteLine("Chcesz zagrać jeszcze raz?\r\n1 - tak\r\n2 - nie");
            int znow = int.Parse(Console.ReadLine());
            switch (znow)
            {
                case 1:
                    Gra();
                    break;

                case 2:
                    Console.WriteLine("Dziękuję za grę!");
                    break;
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
            Gra();
            Znow();
        }
    }
}
