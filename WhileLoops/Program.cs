Random rnd = new Random();
int cpuRandom;
bool loopActive = true; //bool-true/false
while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess. ENter a number between 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Your welcome, you won!");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Oops. Try again.");
    }
}
Console.WriteLine("Have a nice day!");

