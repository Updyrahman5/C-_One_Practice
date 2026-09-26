## Discourse Chapter 2
## Week 2 - C# Core Concepts Practice

Overview
This project demonstrates the following C# concepts:
- Using "var" keyword
- Displaying numeric values
- Formatting output
- Exception handling using "try" and "catch"
- Using constant variables
---
1. var Keyword
The "var" keyword allows implicit typing. The compiler determines the data type automatically.
var age = 20;
var name = "Ali";
var price = 15.5;
---
2. Display Numeric Values
Numeric values can be displayed using "Console.WriteLine()".
int num1 = 10;
double num2 = 5.5;
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine("Sum: " + (num1 + num2));
---
3. Formatting Output
C# supports multiple ways to format output:
Interpolation
double price = 1234.567;
Console.WriteLine($"Price: {price}");
Formatting
Console.WriteLine(price.ToString("N2")); // 2 decimal places
Console.WriteLine(price.ToString("C"));  // Currency format
---
4. Exception Handling
Exception handling prevents the program from crashing when errors occur.
try
{
    int x = 10;
    int y = 0;
    int result = x / y;
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
---
5. Constant Variable
A constant variable cannot be changed after it is declared.
const double PI = 3.14;
Console.WriteLine(PI);
---
6. Full Example
using System;
class Program
{
    static void Main()
    {
        try
        {
            var num1 = 10;
            var num2 = 2;

            const double PI = 3.14;

            var result = num1 / num2;

            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"PI: {PI}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}