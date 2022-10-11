using System;

//Book examples for the Unit 1 C# Program
//to run program use terminal and type "dotnet run"

namespace Unit1_TempExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Fahrenheit temperature value");
            string inputValue = Console.ReadLine();
            double inputTemp = Double.Parse(inputValue);

            Temperature userTemp = new Temperature(inputTemp);
        }
    }
}