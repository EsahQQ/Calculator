namespace Calculator;
class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            var num1 = Calculator.GetNumber("Enter a number: ");
            var operation = Calculator.GetOperation();
            var num2 = Calculator.GetNumber("Enter another number: ");
            var result = operation switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num1 / num2,
                _ => 0
            };

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("One more? (yes / no)");
            var answer = Console.ReadLine();
            if (answer != "yes" && answer != "y")
                return;
        }
    }
}

