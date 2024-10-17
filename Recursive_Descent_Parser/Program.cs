namespace Recursive_Descent_Parser
{
    internal class Program
    {
        // Input string to parse
        private static string inputStr;
        private static int index;
        static void Main(string[] args)
        {
            // Example input: "2+3"
            inputStr = "2+3";
            index = 0;  // Start at the beginning of the input string

            // Start parsing with the starting rule E
            if (ParseE() && index == inputStr.Length)
            {
                Console.WriteLine("Input successfully parsed!");
            }
            else
            {
                Console.WriteLine("Input parsing failed!");
            }
        }

        // Parse the expression E → T + E | T
        private static bool ParseE()
        {
            // First, try to parse T (a term, which is a number in this case)
            if (ParseT())
            {
                // Check if there is a '+' after the term
                if (index < inputStr.Length && inputStr[index] == '+')
                {
                    index++;  // Consume the '+'

                    // After consuming '+', we should have another expression (recursive call to ParseE)
                    return ParseE();
                }
                // If no '+', it's just a single term, which is fine
                return true;
            }
            return false;  // Failed to parse T
        }

        // Parse the term T → num
        private static bool ParseT()
        {
            // Check if the current character is a digit (a number)
            if (index < inputStr.Length && char.IsDigit(inputStr[index]))
            {
                index++;  // Consume the digit (number)
                return true;
            }
            return false;  // Failed to parse a term
        }
    }
}
