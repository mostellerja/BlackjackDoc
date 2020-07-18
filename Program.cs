using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlackjack
{
    class Program
    {//Blackjack (Project)
     //started 5/2/16
     //revised 5/9/16
     //Aaron Mosteller


            /*This program uses methods, variables, and random generator through cases*/


        static string[] playerCards = new string[12];//make new string array
        //called playerCards, this is where we store cards. The max array index 
        //is 12, but you can only hold up to 11 cards.
		
        static string hitOrStay = "";//make new string variable named hitOrStay
        //to ask the player
		
        static int total = 0, count = 1, dealerTotal = 0;//make 3 integer variables called total, which
        //is for our total, count, which is out variable to get an index in out array(we increase to hold more cards), 
        //and dealerTotal, which is the dealer's total.
		
        static Random cardRandomizer = new Random();//make a new instance of Random called cardRandomizer to randomize
        //cards and dealer's total

        static void Main(string[] args)
        {
            Start();
        }
        static string Deal()//this method deals cards
        {
            string Card = "";
            int cards = cardRandomizer.Next(1, 14);
            switch (cards)
            {
                case 1:
                    Card = "Two"; total += 2;
                    break;
                case 2:
                    Card = "Three"; total += 3;

                    break;
                case 3:
                    Card = "Four"; total += 4;

                    break;
                case 4:
                    Card = "Five"; total += 5;

                    break;
                case 5:
                    Card = "Six"; total += 6;

                    break;
                case 6:
                    Card = "Seven"; total += 7;

                    break;
                case 7:
                    Card = "Eight"; total += 8;

                    break;
                case 8:
                    Card = "Nine"; total += 9;

                    break;
                case 9:
                    Card = "Ten"; total += 10;

                    break;
                case 10:
                    Card = "Jack"; total += 10;

                    break;
                case 11:
                    Card = "Queen"; total += 10;

                    break;
                case 12:
                    Card = "King"; total += 10;

                    break;
                case 13:
                    Card = "Ace"; total += 11;

                    break;
                default:
                    Card = "2"; total += 2;

                    break;

            }
            return Card;
        }
        static void Start()
        {
            dealerTotal = cardRandomizer.Next(15, 22); /* A random number between
            15 and 21 for the dealer's number*/
            playerCards[0] = Deal();  //assign the index 0 (our first index) of playerCards[] to the
            //returned value of Deal(); this is the first card dealt
			
            playerCards[1] = Deal();// assign the index 1 (our second index) of playerCards[] to the 
            //returned value of Deal(); this is the second card dealt
            do
            {
                Console.WriteLine("Welcome to Blackjack! You were dealed " + playerCards[0] + " and " +
                    playerCards[1] + ". \nYour total is " + total + ".\nWould you like to hit or stay?");
                hitOrStay = Console.ReadLine().ToLower();

            }
            while (!hitOrStay.Equals("hit") && !hitOrStay.Equals("stay"));/*tell the player what what numbers
            they were given, then ask to hit or stay with the cards they have. do this until the right value is entered.*/
            Game(); //call the game Method

        }
        static void Game()
        {
            if (hitOrStay.Equals("hit")) //if user chooses to hit
            {
                Hit(); //call Hit Method
            }
            else if (hitOrStay.Equals("stay"))//if they choose to stay where they are
            {
                if (total > dealerTotal && total <= 21)//if our total > dealer's total and less than 21
                {
                    Console.WriteLine("\nCongrats! You won the game! The dealer's total was " + dealerTotal +
                        ".\nWould you like to play again? y/n");//tell the user won, tell them the dealer's total, ask them to replay
                    PlayAgain(); //Call the method PlayAgain()
                }
                else if (total < dealerTotal)//if we lose to the dealer
                {
                    Console.WriteLine("\nSorry, you lost! The dealer's total was " + dealerTotal +
                        ".\nWould you like to play again? y/n"); //tell the user they lost, tell them the dealer's total, ask them to replay
                    PlayAgain();//Call the method PlayAgain()
                }
            }



        }
        static void Hit()
        {
            count += 1;//add one to count(where we get the number for index playerCards)
            playerCards[count] = Deal();//Deal a card to our next available index in playerCards
            Console.WriteLine("\nYou were dealt a(n) " + playerCards[count] + ".\nYour new total is " + total
                + "."); // notify the user what they were dealt
            if (total.Equals(21))//if their total is 21 (Blackjack)
            {
                Console.WriteLine("\nYou got Blackjack! The dealer's total was " + dealerTotal +
                    ".\nWould you like to play again?");//tells you that you got blackjack, also tells dealer's total ask to replay
                PlayAgain(); //call PlayAgain() Method
            }
            else if (total > 21) // if their total is more than 21, it is a bust
            {
                Console.WriteLine("\nYou busted, which means you have lost, Sorry! The dealer's total was " +
                    dealerTotal + ".\nWould you like to play again? y/n");// tell player they busted, tell them
                //dealer's total and ask to replay
                PlayAgain(); //call the PlayAgain Method
            }
            else // less than 21
            {
                do
                {
                    Console.WriteLine("\nWould you like to hit or stay?");
                    hitOrStay = Console.ReadLine().ToLower();

                }
                while (!hitOrStay.Equals("hit") && !hitOrStay.Equals("stay"));///ask user to hit or stay,
                //loop until they give a valid response
                Game();//call Game Method

            }
        }
        static void PlayAgain()
        {
            string playAgain = ""; //make a string to ask to replay
            do
            {
                playAgain = Console.ReadLine().ToLower();

            }
            while (!playAgain.Equals("y") && !playAgain.Equals("n"));/*tell the user to press the enter button
            to play another game*/
            if (playAgain.Equals("y")) //if they want to replay
            {
                Console.WriteLine("\nPress enter to restart!");//tell the player to replay by pressing enter
                Console.ReadLine(); //get input (Enter)
                Console.Clear(); //clear the console
                dealerTotal = 0; //reset dealer total
                count = 1;
                total = 0;
                Start();// call the Start() method to replay
            }
            else if (playAgain.Equals("n"))//if the user does not want to play another game
            {
                Console.WriteLine("\nPress the enter key to close Blackjack. (You need to waste a few more productive hours by playing more of this game!)");//tell them to close the game with enter key
                Console.ReadLine();//get input
                Environment.Exit(0); //exit the Console app with exit code 0
            }
        }

                
    }
}
