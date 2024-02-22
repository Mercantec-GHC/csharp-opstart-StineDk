/*Console.WriteLine("Signed integral types:");
Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");*/


/*Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue*/



/*Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");*/


/*int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);*/


/*int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");*/


/*decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");*/


/*decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");*/

// from int to string
/*int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);*/



// from string to int
/*string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);*/


// from string to int with convert class
/*string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);*/


// convert a decimal to an int 
/*int value = (int)1.5m;
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2);*/


/*string name = "Bob";
Console.WriteLine(int.Parse(name));*/


// convert string to int with .TryParse
/*string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");*/



// Experiment with .TryPars in an array
/*string[] values = { "12,3", "45", "ABC", "11", "DEF" };
decimal numbers = 0;
string message = "";
decimal sum = 0;

for ( int i = 0; i < values.Length; i++)
{
    message = values[2] + values[4];
    decimal.TryParse(values[i], out numbers);
    sum += numbers;
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {sum}");*/

// Convert between int, decimal and float
/*int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = value1 / Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");*/


// Array.Sort and Arry.Revers experiment
/*string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($" -- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}*/


// Array.Clear and Array.Resize experiment
/*string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count {pallets.Length}");
pallets[4] = "C01";
pallets[5] = "C02";
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}*/

// Experimenting with Array.Reverse, converting a string to a char array, string.Join adds char between chars in the array, .Split removes the distancing char in between the chars in the array.
/*string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}*/


// Experimenting with reversing the single words
/*string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    char[] pangramChar = words[i].ToCharArray();
    Array.Reverse(pangramChar);
    words[i] = new string(pangramChar);
}
string result = string.Join(" ", words);
Console.WriteLine(result);*/



string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] ordersArray = orderStream.Split(',');
Array.Sort(ordersArray);
for (int i = 0; i < ordersArray.Length; i++)
{
    char[] orderChar = ordersArray[i].ToCharArray();
    if (orderChar.Length == 4)
    {
        Console.WriteLine($"Order number {i}: {ordersArray[i]}");
    }
    else
    {
        Console.WriteLine(@$"Order number {i}: {ordersArray[i]}      - Error");
    }

}