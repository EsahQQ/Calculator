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
            double? result;
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
                    result = num1 / num2;
                    break;
                default:
                    result = null;
                    Console.WriteLine("Invalid input");
                    break;
            }
            if (result == null)
                continue;
    
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("One more? (1 - yes / 0 - no)");
            var answer = Convert.ToInt32(Console.ReadLine());
        }

        return;
    }
}

