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

/*Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus points to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus points to total!");
        total += 2;
    }
}
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}*/

/*string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);
if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}*/

/*Random random = new Random();
int daysUntilExpiration = 1;
//int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Your subscription has expired.");
    }
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine("Your subscription has expired. \nRenew now and save 20%!");
    }
    else if (daysUntilExpiration <= 5)
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. \nRenew now and save 10%!");
    }
    else
    {
        Console.WriteLine("Your subscription wil expire soon. Renew now!");
    }
}
else {}*/

/*string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");*/

/*string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}*/

/*int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventroy.");*/

/*string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}*/

/* The code converts the string to a char array.
Then it reverses the the array, aka the last item is now the first item.
Then it count how many 'o' charecters there is in the array.
Then it converts the array back in to a string, aka it writes the array items in there order.
Then it prints out the answers on the console app.*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = foxesActions.ToCharArray();

Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage) { if (i == 'o') { x++; } }

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

