using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kremala
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Player
    {
        public String Name { get; set; }
        public int GuessesLeft { get; set; }
        public bool Guesser { get; set; }
    
        public Player(String name, bool offence)
        {
            Name = name;
            Guesser = offence;
            if (offence)
            {
                GuessesLeft = 6;
            }
        }
    
        public String SetWord()
        {
                ConsoleKeyInfo word_input;
                Console.WriteLine("Insert Word: ");
                String pass = "";

                while (true)
                {

                    word_input = Console.ReadKey(true);
                    if (word_input.Key == ConsoleKey.Enter)
                    {
                        //όταν πατάμε Enter κάνουμε έξοδο από το loop και δεν δεχόμαστε πλέ
                        break;
                    }
                    else if (word_input.Key == ConsoleKey.Backspace)
                    {
                        //όταν πατάμε backspase σβήνεται ο τελευταίος χαρακτήρας
                        if (pass.Length > 0)
                        {
                            pass = pass.Substring(0, pass.Length - 1);
                            Console.Write("\b \b");
                        }
                    }
                    else
                    {
                        //Αν ο χαρακτήρας που έχει πατηθεί είναι διαφορετικό
                        pass += word_input.KeyChar;
                        Console.Write("*");
                    }
                }
                return pass;

        }
    
        public String GuessLetter()
        {
                Console.WriteLine("Guess a letter: ");
                return (Console.ReadKey().KeyChar).ToString();
            
        }
    }
    
    class Kremala
    {
        public int[] Score { get; set; }
        public Player HangmanPlayer1 { get; set; }
        public Player HangmanPlayer2 { get; set; }
        public String WordToBeFound { get; set; }

        public Kremala()
        {
            Score = new int[2] { 0, 0 };
            //Ο Παίκτης 1 μαντεύει πρώτος
            HangmanPlayer1 = new Player("Paiktis 1", true);
            //Ο Παίκτης 2 βάζει πρώτος λέξη 
            HangmanPlayer2 = new Player("Paiktis 2", false);
            WordToBeFound = "";

        }

        public void GameOn()
        {
            WordToBeFound = HangmanPlayer1.SetWord();
        }

        public void CheckLetter(String letter)
        {
            
        }
    
        public bool GameOver()
        {
            return;
        }
    
        public bool RoundOver()
        {
            return;
        }
    
        public void PrintLetter()
        {
    
        }
    }
}
