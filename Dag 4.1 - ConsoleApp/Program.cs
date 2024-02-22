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


int value1 = 12;
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
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");