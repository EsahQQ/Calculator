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
            double? result = null;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Divide by zero");
                        break;
                    }
                    result = num1 / num2;
                    break;
            }
            if (result != null)
                Console.WriteLine($"Result: {result}");
            
            Console.WriteLine("One more? (yes / no)");
            var answer = Console.ReadLine()?.ToLower();
            if (answer != "yes" && answer != "y")
                return;
        }
    }
}

