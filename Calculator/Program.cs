/*Ask for the first number, an operator (+, -, * or /) and the second number.
Print the result to two decimal places, for example 12.50 * 4.00 = 50.00.
If the user types an invalid number, ask again. Use ReadNumber above.
If the user types an invalid operator, ask again.
Dividing by zero must not crash. Print a friendly message instead.
After each calculation, ask Calculate again? (y/n). Use a do-while.
When they type n, print a goodbye message.
*/
using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;


Console.WriteLine("=== Console Calculator ===");

do
{
    decimal firstNumber = ReadNumber("Enter the first number: ");
    string op = ReadOperator();
    decimal secondNumber = ReadNumber("Enter the second number: ");

    if (op == "/" && secondNumber == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    else
    {
        decimal result = Calculate(firstNumber, secondNumber, op);
        Console.WriteLine($"{firstNumber:F2} {op} {secondNumber:F2} = {result:F2}");
    }

    Console.Write("Calculate again? (y/n): ");
} while (Console.ReadLine()?.Trim().ToLower() == "y");

Console.WriteLine("Goodbye!");

decimal ReadNumber(string prompt)
{
    Console.Write(prompt);
    string? input = Console.ReadLine();

    decimal number;
    while (!decimal.TryParse(input, out number))
    {
        Console.Write("Invalid number, please try again: ");
        input = Console.ReadLine();
    }

    return number;
}

string ReadOperator()
{
    Console.Write("Enter operator (+ - * /): ");
    string? op = Console.ReadLine();

    while (op != "+" && op != "-" && op != "*" && op != "/")
    {
        Console.Write("Invalid operator, please try again: ");
        op = Console.ReadLine();
    }

    return op;
}


decimal Calculate(decimal a, decimal b, string op)
{
    return op switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" => a / b,
        _ => 0
    };
}
