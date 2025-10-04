namespace Calculator;

public static class Calculator
{
    public static double GetNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (!double.TryParse(Console.ReadLine(), out var number))
            {
                Console.WriteLine("Invalid input, please try again\n");
                continue;
            }
            
            return number;
        }
    }
}