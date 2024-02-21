/*Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue ==  "a");*/


/*string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());*/


/*Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");*/


/*Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);*/


/*string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));*/


/*string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));*/


/*string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));*/


/*int a = 7;
int b = 6;
Console.WriteLine(a != b);
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2);*/


/*int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");*/


/*int saleamount = 1001;
Console.WriteLine($"Discount: {(saleamount > 1000 ? 100 : 50)}");*/




/* Random number = new Random();
int result = number.Next(1, 3);
Console.WriteLine($"Coin landed on: {(result > 1 ? "Heads" : "Tails")}");

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");*/


/*string permission = "Admin|Manager";
int level = 20;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
    Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}*/


/*bool flag = true;
if (flag) Console.WriteLine(flag);*/

/*string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");*/

/*string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");*/



/*int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        bool found = true;

        if(found)
        {
            Console.WriteLine("Set contains 42");
        }
    }

}
Console.WriteLine($"Total: {total}");*/



/*int emplayeeLevel = 201;
string emplayeeName = "John Smith";
string title = "";

switch (emplayeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = " Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}
Console.WriteLine($"{emplayeeName}, {title}");*/



/*
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}
Console.WriteLine($"Product: {size} {color} {type}");*/



/*for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}*/


/*string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}*/

/*string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}
foreach (var name in names)
{
    Console.WriteLine(name);
}*/



/*for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine(i);
}*/



/*Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);*/



/*Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");*/



/*Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);*/


/*Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;

do
{
    int attack = random.Next(1, 11);
    monsterHealth -= attack;
    Console.WriteLine($"The monster lost {attack} health points and has {monsterHealth} health points left.");

    if (monsterHealth <= 0)
    {
       continue;
    }

    attack = random.Next(1, 11);
    heroHealth -= attack;
    Console.WriteLine($"The hero lost {attack} health points and has {heroHealth} health points left.");

} while (monsterHealth > 0 && heroHealth > 0);
Console.WriteLine(heroHealth > monsterHealth ? "Hero Wins!" : "Monster wins!");*/



/*string? readResult;
string choice = "";
int nummericChoice = 0;
bool validNumber = false;

Console.WriteLine("Pick a number between 5 and 10.");

do
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        choice = readResult;
    }

    validNumber = int.TryParse(choice, out nummericChoice);

    if (validNumber == true)
    {
        if (nummericChoice <= 5 || nummericChoice >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {nummericChoice}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({nummericChoice}) has been accepted.");*/




string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();