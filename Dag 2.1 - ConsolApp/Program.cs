/*Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
Random dice = new();*/

/*Random dice = new Random();
// The Next() gives a boundary from 0 - 2.147.483.647 
int roll1 = dice.Next();
// The Next(101) gives a boundary for 0 - 101
int roll2 = dice.Next(101);
// The Next(50, 101) gives a boundary form 50 - 101
int roll3 = dice.Next(50, 101);
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");*/

/*int firstValue = 500;
int secondValue = 600;
// Saves the higeher of the 2 values in the new variable
int largerValue = Math.Max(secondValue, firstValue);
Console.WriteLine(largerValue);*/

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus points to total!");
    total += 6;
}
else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus points to total!");
    total += 2;
}
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}


/*string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);
if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}*/