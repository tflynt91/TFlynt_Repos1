using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int theAnswer;
            int theSAnswer;
            int theTAnswer;
            int playerGuess;
            int guessCount = 0;
            string playerInput;

            Random r = new Random();
            theAnswer = r.Next(1, 21);
            Random s = new Random();
            theSAnswer = s.Next(1, 51);
            Random t = new Random();
            theTAnswer = t.Next(1, 6);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("\nChoose your difficulty level: Easy(1-5) Normal(1-20) or Hard(1-50): ");
            string gameMode = Console.ReadLine();
            if(gameMode.ToLower().Equals("normal"))
            {
                do
                {
                    // get player input
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Hello, {userName}! Enter your guess (1-20) or press 'Q' to quit: ");
                    Console.ResetColor();
                    playerInput = Console.ReadLine();

                    if(playerInput.ToUpper().Equals("Q"))
                    {       
                        System.Environment.Exit(0);
                    }
                    else 
                    {

                
                        //attempt to convert the string to a number
                        if (int.TryParse(playerInput, out playerGuess))
                        {
                            if(playerGuess >= 1 && playerGuess <=20)
                            {
                                if (playerGuess == theAnswer)
                                {
                                    if(guessCount == 0)
                                    {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{theAnswer} was the number.  Congrats {userName}, You Win! You got it on the first attempt!");
                                    Console.ResetColor();
                                    break; 
                                    }
                                    else 
                                    {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{theAnswer} was the number.  Congrats {userName}, You Win! It only took {guessCount} attempts!");
                                    Console.ResetColor();
                                    break; 
                                    }
                                }
                                else
                                {
                                    if (playerGuess > theAnswer)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine($"Sorry {userName}, Your guess was too High!");
                                        Console.ResetColor();
                                        guessCount++;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine($"Sorry {userName}, Your guess was too low!");
                                        Console.ResetColor();
                                        guessCount++;
                                    }
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sorry, that number was not within the valid range!");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That wasn't a number!");
                            Console.ResetColor();
                        }
                    }
                

                } while (true);
            }
            else if(gameMode.ToLower().Equals("easy"))
            {
                do
                {
                    // get player input
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Hello, {userName}! Enter your guess (1-5) or press 'Q' to quit: ");
                    Console.ResetColor();
                    playerInput = Console.ReadLine();

                    if(playerInput.ToUpper().Equals("Q"))
                    {       
                        System.Environment.Exit(0);
                    }
                    else 
                    {

                
                        //attempt to convert the string to a number
                        if (int.TryParse(playerInput, out playerGuess))
                        {
                            if(playerGuess >= 1 && playerGuess <=5)
                            {
                                if (playerGuess == theTAnswer)
                                {
                                    if(guessCount == 0)
                                    {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{theTAnswer} was the number.  Congrats {userName}, You Win! You got it on the first attempt!");
                                    Console.ResetColor();
                                    break; 
                                    }
                                    else 
                                    {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{theTAnswer} was the number.  Congrats {userName}, You Win! It only took {guessCount} attempts!");
                                    Console.ResetColor();
                                    break; 
                                    }
                                }
                                else
                                {
                                    if (playerGuess > theTAnswer)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine($"Sorry {userName}, Your guess was too High!");
                                        Console.ResetColor();
                                        guessCount++;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine($"Sorry {userName}, Your guess was too low!");
                                        Console.ResetColor();
                                        guessCount++;
                                    }
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sorry, that number was not within the valid range!");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That wasn't a number!");
                            Console.ResetColor();
                        }
                    }
                

                } while (true);
            }
            else if(gameMode.ToLower().Equals("hard"))
            {
                do
                {
                    // get player input
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Hello, {userName}! Enter your guess (1-50) or press 'Q' to quit: ");
                    Console.ResetColor();
                    playerInput = Console.ReadLine();

                    if(playerInput.ToUpper().Equals("Q"))
                    {       
                        System.Environment.Exit(0);
                    }
                    else 
                    {

                
                        //attempt to convert the string to a number
                        if (int.TryParse(playerInput, out playerGuess))
                        {
                            if(playerGuess >= 1 && playerGuess <=50)
                            {
                                if (playerGuess == theSAnswer)
                                {
                                    if(guessCount == 0)
                                    {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{theSAnswer} was the number.  Congrats {userName}, You Win! You got it on the first attempt!");
                                    Console.ResetColor();
                                    break; 
                                    }
                                    else 
                                    {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{theSAnswer} was the number.  Congrats {userName}, You Win! It only took {guessCount} attempts!");
                                    Console.ResetColor();
                                    break; 
                                    }
                                }
                                else
                                {
                                    if (playerGuess > theSAnswer)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine($"Sorry {userName}, Your guess was too High!");
                                        Console.ResetColor();
                                        guessCount++;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine($"Sorry {userName}, Your guess was too low!");
                                        Console.ResetColor();
                                        guessCount++;
                                    }
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sorry, that number was not within the valid range!");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That wasn't a number!");
                            Console.ResetColor();
                        }
                    }
                

                } while (true);
            }
            else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That wasn't a correct mode");
                            return;
                            Console.ResetColor();
                        }
              

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
