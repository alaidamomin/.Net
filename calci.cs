class Calculator
{
    public static void Main()
    {
        char ch;

        Console.WriteLine("*============ Simple Calculator ============*");
        Console.WriteLine("");

        do
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.WriteLine("Choose Option to perform Arithmetic Operations between 1 to 4:");
            int op = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine($"Addition = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Subtraction = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication = {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Division = {num1 / (double)num2}");
                    }
                    else
                    {
                        Console.WriteLine("Can't divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            Console.WriteLine("Do you want to repeat: (y/n)");
            ch = Convert.ToChar(Console.ReadLine());

        } while (ch == 'y' || ch == 'Y');

        Console.WriteLine("*================== Exit ==================*");
    }
}