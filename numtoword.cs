class NumberToWordsConverter
{
    private static string[] ones = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
    private static string[] teens = {"", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    private static string[] tens = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

    public static string ConvertToWords(long number)
    {
        if (number == 0)
            return "Zero";

        if (number < 0)
            return "Negative " + ConvertToWords(-number);

        string words = "";

        if ((number / 1000000000) > 0)
        {
            words += ConvertToWords(number / 1000000000) + " Billion ";
            number %= 1000000000;
        }

        if ((number / 1000000) > 0)
        {
            words += ConvertToWords(number / 1000000) + " Million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += ConvertToWords(number / 1000) + " Thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += ConvertToWords(number / 100) + " Hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            if (number < 10)
                words += ones[number];
            else if (number < 20)
                words += teens[number - 10];
            else
            {
                words += tens[number / 10];
                if ((number % 10) > 0)
                    words += "-" + ones[number % 10];
            }
        }

        return words;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        if (long.TryParse(Console.ReadLine(), out long number))
        {
            string words = ConvertToWords(number);
            Console.WriteLine($"{number} = {words}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}