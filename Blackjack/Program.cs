using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Blackjack
    {
        static int[] playerCards = new int[11];
        static int[] computerCards = new int[11];
        static string hitOrStay = "";
        static int yourScore = 0, count = 1, computerScore = 0;
        static Random cardRandomizer = new Random();

        static void Main(string[] args)
        {
            Console.Title = "BlackJack";
            Start();
        }

        static void Start()
        {
            //computerScore = cardRandomizer.Next(15, 22);
            playerCards[0] = Deal();
            playerCards[1] = Deal();
            computerCards[0] = Deal();
            computerCards[1] = Deal();

            yourScore = playerCards[0] + playerCards[1];
            computerScore = computerCards[0] + computerCards[1];
            do
            {
                Console.WriteLine("Your Cards: " + playerCards[0] + " " + playerCards[1] + " = " + yourScore);
                Console.WriteLine("Computer Cards: " + computerCards[0] + " " + computerCards[1] + " = " + computerScore);
                Console.WriteLine("Do you want another card (y/n)?");
                hitOrStay = Console.ReadLine().ToLower();
            } while (!hitOrStay.Equals("y") && !hitOrStay.Equals("n"));
            Game();
        }

        static void Game()
        {
            if (hitOrStay.Equals("y"))
            {
                Hit();
            }
            else if (hitOrStay.Equals("n"))
            {
                DisplayScores();
                ShowCards showCards = new ShowCards();
                Console.WriteLine(showCards.Check(yourScore, computerScore));
            }
            Console.WriteLine("\nWould you like to play again (y/n)?");
            PlayAgain();
            Console.ReadLine();
        }

        static int Deal()
        {
            int Card = cardRandomizer.Next(1, 10);
            return Card;
        }

        static void Hit()
        {
            count += 1;
            playerCards[count] = Deal();
            computerCards[count] = Deal();

            yourScore += playerCards[count];
            computerScore += computerCards[count];

            Console.WriteLine("\nHit: " + playerCards[count] + " Your total is " + yourScore);
            
            if (yourScore < 21)
            {
                do
                {
                    Console.WriteLine("\nDo you want another card (y/n)?");
                    hitOrStay = Console.ReadLine().ToLower();
                } while (!hitOrStay.Equals("y") && !hitOrStay.Equals("n"));
                Game();
            }
            else if (yourScore > 21)
            {
                Console.WriteLine("\nYou lost.");
            }
            else if (yourScore < computerScore && computerScore <= 21)
            {
                Console.WriteLine("\nYou lost.");
            }
        }

        private static void DisplayScores()
        {
            Console.WriteLine("\nThe computer takes a card: " + computerCards[count]);
            Console.WriteLine("Your score: " + yourScore);
            Console.WriteLine("Computer score: " + computerScore);
        }

        static void PlayAgain()
        {
            string playAgain = "";
            do
            {
                playAgain = Console.ReadLine().ToLower();
            } while (!playAgain.Equals("y") && !playAgain.Equals("n"));
            if (playAgain.Equals("y"))
            {
                Console.WriteLine("\nPress enter to restart the game!");
                Console.ReadLine();
                Console.Clear();
                computerScore = 0;
                count = 1;
                yourScore = 0;
                Start();
            }
            else if (playAgain.Equals("n"))
            {
                Console.WriteLine("\nPress enter to close Blackjack.");
                Console.ReadLine();
                Environment.Exit(0);
            }

        }

        public string Check()
        {
            return "You Won!";
        }
    }
}
