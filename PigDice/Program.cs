﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pig Dice");
            Player Player1 = new Player();
            bool PlayerTurn = true;
            int CurrentRoll;
            char BankOrRoll;

            while (PlayerTurn)
            {
                CurrentRoll = DiceRoll();
                Console.WriteLine($"The Dice Roll was {CurrentRoll}");
                if (CurrentRoll == 1)
                {
                    PlayerTurn = false;
                }
                else
                {
                    Player1.TurnScore = Player1.TurnScore + CurrentRoll;
                    Console.WriteLine($"Your Score this turn is currently {Player1.TurnScore}");
                    Console.Write($"Would you like to bank your {Player1.TurnScore} or roll again?");
                    Console.WriteLine("Please enter B or R");
                    BankOrRoll = char.Parse(Console.ReadLine());
                    while (BankOrRoll != 'B' && BankOrRoll != 'b' && BankOrRoll != 'R' && BankOrRoll != 'r')
                    {
                        Console.WriteLine("Please enter B or R");
                        BankOrRoll = char.Parse(Console.ReadLine());
                    }

                    if(BankOrRoll == 'B' || BankOrRoll == 'b')
                    {
                            //if bank
                            // add turnscore to score and break out of turn
                    }
                    else if(BankOrRoll == 'R' || BankOrRoll == 'r')
                    {

                    }
                    
                }




                //test win
                //if win display win text
            }



            Console.ReadLine();
        }

        static int DiceRoll()
        {
            Random r = new Random();
            int Roll = r.Next(1, 6);
            return Roll;
        }
    }

    public class Player
    {
        //string Name;
        public int Score = 0;
        public int TurnScore = 0;

        /* public static void SetPlayerName(ref string name)
         {
             Console.WriteLine("What is your name?");
             name = Console.ReadLine();
         } */
    }
}
