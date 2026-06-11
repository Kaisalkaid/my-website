using System;

class Calculator
{
    // This method takes two integers as parameters
    public void DisplayNumbers(int firstNumber, int secondNumber)
    {
        // Do a math operation on the first integer
        int result = firstNumber + 10;

        // Display the result of the math operation
        Console.WriteLine("Result: " + result);

        // Display the second integer
        Console.WriteLine("Second Number: " + secondNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the Calculator class
        Calculator calc = new Calculator();

        // Call the method and pass in two numbers
        calc.DisplayNumbers(5, 10);

        // Call the method again using named parameters
        calc.DisplayNumbers(firstNumber: 20, secondNumber: 30);
    }
}