// See https://aka.ms/new-console-template for more information
Console.WriteLine("Number Guessing Game!");
Console.WriteLine("You have three guesses");

Random randomNumber = new Random();
var number = randomNumber.Next(1, 11); 

Console.WriteLine("The computer has picked a number");
Console.WriteLine("What is your first guess?: ");
int firstGuess; 
bool isTrueGuessOne = int.TryParse(Console.ReadLine(), out firstGuess);
if (isTrueGuessOne)

if (firstGuess == number)
{
    Console.WriteLine("Congratulations! You picked the correct number!");
}
else
{
    Console.WriteLine("Incorrect");
    Console.WriteLine("What is your second guess?: ");
int secondGuess; 
bool isTrueGuessTwo = int.TryParse(Console.ReadLine(), out secondGuess);
if (isTrueGuessTwo)

if (secondGuess == number)
{
  Console.WriteLine("Congratulations! You picked the correct number!");  
}
else
{
   Console.WriteLine("Incorrect Again");
    Console.WriteLine("What is your third guess?: ");
int thirdGuess; 
bool isTrueGuessThree = int.TryParse(Console.ReadLine(), out thirdGuess);
if (isTrueGuessThree)

if (thirdGuess == number)
{
  Console.WriteLine("Congratulations! You picked the correct number!");  
}
else
{
    Console.WriteLine("Incorrect. Unfortunately all your guesses have been used up. Thanks for playing!");
}
}
}





