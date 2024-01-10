// See https://aka.ms/new-console-template for more information
using D_Practice;
using System.Runtime.CompilerServices;

//Homework0801
/*
Develop a class representing a complex number. The class must contain two properties to represent the real (double) and imaginary parts (double).
It was impossible to create an instance of a class without passing the appropriate arguments.
 */
//var homework0801 = new Homework0801();
//double result = homework0801.Foo(1.0,2.0,3.0);
//Console.WriteLine($"Homework0801. result = {result}");

//Homework0803
/*
Develop a "guess the number" game.

One of the players guesses a number from 0 to 100 (by default), and the second tries to guess in a limited number of attempts (5 by default).
When the second player makes a guess about the hidden number, the first player reports whether the number was guessed, whether it is less than the guessed number, or
more. If you guess correctly, the game is over. If there is less or more than what was hidden, then the second player narrows the search area and continues to try
guess. This happens until either the number is guessed or the number of attempts is exhausted.

Both a person and a machine can make a wish. Accordingly, both a person and a machine can guess. This means that we need to implement
two game modes: when the machine makes a wish and when a person makes a wish.

If a person guesses and a machine guesses, then you need to make sure that the machine tries to guess the number using a binary search algorithm.

An example of a binary search for a hidden number: the number 18 was guessed, provided that the number was guessed in the range from 0 to 100. Each player
once takes the middle, i.e. On the first try, he guesses the number 50. The first player says that the guessed number is less. So the number lies
between 0 and 50. Then the second player again divides the range by 2 and guesses 25. The first player says that the guessed number is less. Means
a number between 0 and 25. Then the second player again divides the range by 2 and guesses 12 (we simply cut off the fractional part). First player
says that the hidden number is greater. This means the number lies in the range between 12 and 25. The second player divides the range by two and guesses 18.
The first player says that the number is correct. Game over.

On each attempt, thanks to this strategy, the search range is narrowed by half. This is the essence of binary search. At the end of the game it is displayed
information about whether victory has been achieved or not. Of course, it will be necessary to implement dialogue between players.
 */
//var homework0803 = new Homework0803();
//homework0803.Game();

//Homework0805
/*
Tic tac toe
*/
var homework0805 = new Homework0805();
while (true)
{
    Console.WriteLine("Start?");
    Console.ReadLine();
    homework0805.Game();
}