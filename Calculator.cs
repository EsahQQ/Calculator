namespace Calculator;

public static class Calculator
{
    public static double GetNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out var number)) 
                return number;
            
            Console.WriteLine("Invalid input, please try again\n");
        }
    }
    
    public static string GetOperation()
    {
        while (true)
        {
            Console.Write("Choose operation (+, -, /, *): ");
            var operation = Console.ReadLine();
            if (operation is "+" or "-" or "/" or "*") 
                return operation;
                
            Console.WriteLine("Invalid input, please try again\n");
        }
    }
}