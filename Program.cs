using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            IntroToApp();
            GetUserPerfence();
            while (true)
            {
                Random random = new Random();
                int UserInput, Correctno = random.Next(0, 10);
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Guess the number:");
                    try
                    {
                        UserInput = Convert.ToInt32(Console.ReadLine());


                        if (UserInput == Correctno)
                        {
                            Console.WriteLine("CORRECT GUESS !! YAY");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong answer try again");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("Do you want to play again [Y/N]?");

                string WillContiune =  Console.ReadLine().ToUpper();
                if (WillContiune == "Y")
                {
                    continue;

                }
                else 
                {
                   break;

                }
            }






        }
        
        static void IntroToApp()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("_____________________________");
            Console.WriteLine("|Gusseing game VERSION 1.0.0.|");
            Console.WriteLine("|____________________________|");
            Console.ResetColor();
        }
        static void GetUserPerfence()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("What  is your name :");
            Console.ResetColor ();
            string UserName = Console.ReadLine().ToLower();           
            Console.WriteLine("\n\n____________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello," + (UserName.Substring(0, 1).ToUpper() + UserName.Substring(1)) + " . Hope you Enjoy the game");
            Console.ResetColor();
        }
    }
}
