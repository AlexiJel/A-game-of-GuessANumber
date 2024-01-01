Random random = new Random();
int computersRandomNumber = random.Next(1, 101);

Console.Write("Guess a number (1-100): ");
int playersNumber = int.Parse(Console.ReadLine());

while (playersNumber != computersRandomNumber)
{
    if (playersNumber < computersRandomNumber)
    {
        Console.WriteLine("Too Low");
    }
    else if (playersNumber > computersRandomNumber)
    {
        Console.WriteLine("Too High");
    }
    playersNumber = int.Parse(Console.ReadLine());
}
if (playersNumber == computersRandomNumber)
{
    Console.WriteLine("You guessed it!");
}