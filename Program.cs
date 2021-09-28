using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

            Console.WriteLine("Hello user, What is your name?");
            string userName = Console.ReadLine();

            while (runProgram == true)
            {
                Console.WriteLine("Enter a number between 1 and 100");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput % 2 != 0 && userInput <= 60) 
                {
                Console.WriteLine($"{userName} your number {userInput}, is Odd");
                }
                else if (userInput % 2 == 0 && userInput < 25 && userInput >= 2)
                {
                Console.WriteLine($"{userName} your number {userInput}, is Even and less than 25.");
                }
                else if (userInput % 2 == 0 && userInput >= 26 && userInput < 60)
                {
                Console.WriteLine($"{userName} your number {userInput}, is Even and in the range of 26 to 60.");
                }
                else if (userInput % 2 ==0 && userInput >= 60)
                {
                Console.WriteLine($"{userName} your number {userInput}, is Even and greater than 60.");
                }
                else if (userInput % 2 != 0 && userInput >= 60)
                {
                Console.WriteLine($"{userName} your number {userInput}, is Odd and greater than 60.");
                }
                else
                {
                Console.WriteLine($"Sorry, {userName} the number {userInput} is not a valid number for the Integer Range.");
                }
            
                Console.WriteLine("Continue? (y/n)");
                string loopAnswer = Console.ReadLine();
                if (loopAnswer == "n")
                {
                    runProgram = false;
                    Console.WriteLine($"Bye! {userName}");
                }
                
            }
        }
    }
}
