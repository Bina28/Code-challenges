namespace Code_challenges;

public class Calculator
{

    public static void Run()
    {
        bool isRunnig = true;
        while (isRunnig)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Calculator Game! Select an operation to get started:");
            Console.WriteLine($@"{MathOperation.Multiply} - m 
{MathOperation.Divide} - d
{MathOperation.Subtract} - s
{MathOperation.Add} - a");

            char userMathOperationInput;

            do
            {
                Console.Write("Enter an operation (m/d/s/a)");
                userMathOperationInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userMathOperationInput != 'm' && userMathOperationInput != 'd' && userMathOperationInput != 's' && userMathOperationInput != 'a');


            double number1 = InputValidation("Enter the first number: ");
            double number2 = InputValidation("Enter the second number: ");


            double result = userMathOperationInput switch
            {
                'm' => Multiply(number1, number2),
                'd' => Divide(number1, number2),
                's' => Subtract(number1, number2),
                'a' => Add(number1, number2),
                _ => throw new InvalidOperationException("Invalid operation input.")
            };

            Console.WriteLine($"The result of the math operation: {result}");
            Console.WriteLine("Press any key to continue or 'e' to exit");
            if (Console.ReadKey().KeyChar == 'e')
            {
                isRunnig = false;
            }
        }
    }

    public static double InputValidation(string message)
    {
        double result;
        string? input;
        do
        {
            Console.WriteLine(message);
            input = Console.ReadLine();
        } while (!double.TryParse(input, out result));
        return result;
    }

    public static double Multiply(double number1, double number2) => number1 * number2;
    public static double Subtract(double number1, double number2) => number1 - number2;
    public static double Add(double number1, double number2) => number1 + number2;
    public static double Divide(double number1, double number2)
    {
        while (number2 == 0)
        {
            number2 = InputValidation("The divisor cannot be zero. Please enter a valid second number: ");
        }

        return number1 / number2;
    }

}
public enum MathOperation
{
    Multiply,
    Add,
    Subtract,
    Divide
}





