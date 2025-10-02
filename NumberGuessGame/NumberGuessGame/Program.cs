using System;

class NumberGuessingGame;
{
    static void Main()
    {
        Random rand = new Random():
        bool playing = true;

    do
    {
        Console.WriteLine("Choose difficulty: Easy (1-10), Medium (1-50), Hard (1-100)");
        string difficulty = Console.ReadLine().ToLower();
