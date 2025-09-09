using System;
using System;

class Reversed
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("\nEnter string: ");
            string str = Console.ReadLine();

            // Exit condition
            if (str == "*")
            {
                Console.WriteLine("\n//End execution");
                break; // titigil na ang loop, hindi na magtatanong ulit
            }

            // Convert to lowercase for checking
            string lowerStr = str.ToLower();

            // Reverse manually (no built-in reverse)
            string reversed = "";
            for (int i = lowerStr.Length - 1; i >= 0; i--)
            {
                reversed += lowerStr[i];
            }

            // Check palindrome
            string result = (lowerStr == reversed) ? "Yes" : "No";

            // Display formatted output
            Console.WriteLine("\nOriginal String\t\tReversed String\t\tPalindrome?");
            Console.WriteLine("  {0}\t\t\t{1}\t\t\t{2}", str, reversed, result);
        }
        Console.ReadKey();
    }
}
