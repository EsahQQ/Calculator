namespace Calculator;
class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t1. +");
            Console.WriteLine("\t2. -");
            Console.WriteLine("\t3. *");
            Console.WriteLine("\t4. /");
            Console.Write("Choose operation: ");
            var operation = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            int? result;
            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
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

