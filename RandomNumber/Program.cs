Random rnd  = new Random();

int myRandomNum;
int randomSUm = 0;

for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11);
    randomSUm = randomSUm  + myRandomNum;
    Console.WriteLine($"My Random number is:{myRandomNum}");
}

Console.WriteLine($"random sum total: {randomSUm}");