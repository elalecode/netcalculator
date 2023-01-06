internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What's your name? Please write your full name.");
        string fullUserName = Console.ReadLine();
        Console.WriteLine("hello " + fullUserName + " Welcome!");

        // Calculator
        int number1;
        int number2;

        Console.WriteLine("Input the first number:");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the second number:");
        number2 = Convert.ToInt32(Console.ReadLine());

        int result = number1 * number2;
        Console.WriteLine("The result will is: " + result);

        // Using string
        int heigth = 170;
        int age = 27;
        string name = "Edwin JIMENEZ";
        string information = $"The information you requested is: {name}, {age} años, {heigth} cm de altura.";
        
        Console.WriteLine(information);

        // Reactangle area program
        int sideA = 10;
        int sideB = 20;

        int area = sideA * sideB;
        Console.WriteLine($"The area of rectangle is: {area}");

        // Logical operators: and, or, not (&&, ||, !)
        bool value1 = true;
        bool value2 = false;
        bool value3 = false;

        Console.WriteLine($"Value 1: {value1}");
        Console.WriteLine($"Value 2: {value2}");
        Console.WriteLine($"Value 3: {value3}");

        bool resultAND = value1 && value2;
        Console.WriteLine($"The result of the logical value1 AND value2 is: {resultAND}");

        bool resultOR = value1 || value2 || value3;
        Console.WriteLine($"The result of the logical value1 OR value2 OR value3 is: {resultOR}");

        bool resultNOT = !value1;
        Console.WriteLine($"The result of the logical NOT value1 is: {resultNOT}");
    }
}