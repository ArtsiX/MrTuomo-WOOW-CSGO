using System;
using CSGSI;
using CSGSI.Nodes;
using System.Media;
using System.IO;

namespace Mullistava_WOOOW_CSGO_ohjelma_VAC_FREE
{
    class Program
    {
        static int roundkills = 0;
        static int roundkillsreq = 1;

        static GameStateListener gsl;
        static void Main(string[] args)
        {
            gsl = new GameStateListener(3000);
            gsl.NewGameState += new NewGameStateHandler(OnNewGameState);
            if (!gsl.Start())
            {
                Environment.Exit(0);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mullistava WOOOOW ohjelma käynnistetty!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|~~~~~~~~~~ Kehittäjä: ArtsiX ~~~~~~~~~~|");
            Console.WriteLine("");
        }
        static void OnNewGameState(GameState gs)
        {
            if (gs.Player.MatchStats.Kills == 1)
            {
                roundkills = 1;
            }

            if (gs.Player.MatchStats.Kills == 2)
            {
                roundkills = 2;
            }

            if (gs.Player.MatchStats.Kills == 3)
            {
                roundkills = 3;
            }

            if (gs.Player.MatchStats.Kills == 4)
            {
                roundkills = 4;
            }

            if (gs.Player.MatchStats.Kills == 5)
            {
                roundkills = 5;
            }

            if (gs.Player.MatchStats.Kills == 6)
            {
                roundkills = 6;
            }

            if (gs.Player.MatchStats.Kills == 7)
            {
                roundkills = 7;
            }

            if (gs.Player.MatchStats.Kills == 8)
            {
                roundkills = 8;
            }

            if (gs.Player.MatchStats.Kills == 9)
            {
                roundkills = 9;
            }

            if (gs.Player.MatchStats.Kills == 11)
            {
                roundkills = 11;
            }

            if (gs.Player.MatchStats.Kills == 12)
            {
                roundkills = 12;
            }

            if (gs.Player.MatchStats.Kills == 13)
            {
                roundkills = 13;
            }

            if (gs.Player.MatchStats.Kills == 14)
            {
                roundkills = 14;
            }

            if (gs.Player.MatchStats.Kills == 15)
            {
                roundkills = 15;
            }

            if (gs.Player.MatchStats.Kills == 16)
            {
                roundkills = 16;
            }

            if (gs.Player.MatchStats.Kills == 17)
            {
                roundkills = 17;
            }

            if (gs.Player.MatchStats.Kills == 18)
            {
                roundkills = 18;
            }

            if (gs.Player.MatchStats.Kills == 19)
            {
                roundkills = 19;
            }

            if (gs.Player.MatchStats.Kills == 20)
            {
                roundkills = 20;
            }

            if (gs.Player.MatchStats.Kills == 20)
            {
                roundkills = 20;
            }

            if (gs.Player.MatchStats.Kills == 21)
            {
                roundkills = 21;
            }

            if (gs.Player.MatchStats.Kills == 21)
            {
                roundkills = 21;
            }

            if (gs.Player.MatchStats.Kills == 22)
            {
                roundkills = 22;
            }

            if (gs.Player.MatchStats.Kills == 23)
            {
                roundkills = 23;
            }

            if (gs.Player.MatchStats.Kills == 24)
            {
                roundkills = 24;
            }

            if (gs.Player.MatchStats.Kills == 25)
            {
                roundkills = 25;
            }

            if (gs.Player.MatchStats.Kills == 26)
            {
                roundkills = 26;
            }

            if (gs.Player.MatchStats.Kills == 27)
            {
                roundkills = 27;
            }

            if (gs.Player.MatchStats.Kills == 28)
            {
                roundkills = 28;
            }

            if (gs.Player.MatchStats.Kills == 29)
            {
                roundkills = 29;
            }

            if (gs.Player.MatchStats.Kills == 30)
            {
                roundkills = 30;
            }

            if (gs.Player.MatchStats.Kills == 31)
            {
                roundkills = 31;
            }

            if (gs.Player.MatchStats.Kills == 32)
            {
                roundkills = 32;
            }

            if (gs.Player.MatchStats.Kills == 33)
            {
                roundkills = 33;
            }

            if (gs.Player.MatchStats.Kills == 34)
            {
                roundkills = 34;
            }

            if (gs.Player.MatchStats.Kills == 35)
            {
                roundkills = 35;
            }

            if (gs.Player.MatchStats.Kills == 36)
            {
                roundkills = 36;
            }

            if (gs.Player.MatchStats.Kills == 37)
            {
                roundkills = 37;
            }

            if (gs.Player.MatchStats.Kills == 38)
            {
                roundkills = 38;
            }

            if (gs.Player.MatchStats.Kills == 39)
            {
                roundkills = 39;
            }

            if (gs.Player.MatchStats.Kills == 40)
            {
                roundkills = 40;
            }

            if (gs.Player.MatchStats.Kills == 41)
            {
                roundkills = 41;
            }

            if (gs.Player.MatchStats.Kills == 42)
            {
                roundkills = 42;
            }

            if (gs.Player.MatchStats.Kills == 43)
            {
                roundkills = 43;
            }

            if (gs.Player.MatchStats.Kills == 44)
            {
                roundkills = 44;
            }

            if (gs.Player.MatchStats.Kills == 45)
            {
                roundkills = 45;
            }

            if (gs.Player.MatchStats.Kills == 46)
            {
                roundkills = 46;
            }

            if (gs.Player.MatchStats.Kills == 47)
            {
                roundkills = 47;
            }

            if (gs.Player.MatchStats.Kills == 48)
            {
                roundkills = 48;
            }

            if (gs.Player.MatchStats.Kills == 49)
            {
                roundkills = 49;
            }

            if (gs.Player.MatchStats.Kills == 50)
            {
                roundkills = 50;
            }

            if (roundkills >= roundkillsreq)
            {
                Stream str = Properties.Resources.wooow;
                SoundPlayer snd = new SoundPlayer(str);
                snd.Play();
                roundkillsreq = roundkills + 1;
                Console.WriteLine("WOOOW mittari: " + roundkills);
            }

            if (roundkills > 50)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!! YLITIT 50 TAPON RAJAN!! Were all out of sounds !!!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}