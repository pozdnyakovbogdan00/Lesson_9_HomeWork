class natural_numbers
{
    public static void natural_numbers_metod()
    {
        // Input user data
        Console.WriteLine("Enter first number:");
        int M = Convert.ToInt32(Console.ReadLine()); // first number 
        Console.WriteLine("Enter second number:");
        int N = Convert.ToInt32(Console.ReadLine()); // second number 

        Console.WriteLine("Result: ");
        // Find recursively natural numbers
        find_natural_number(M, N);

    }

    private static void find_natural_number(int CurrentNumber, int Stop)
    {
        if (CurrentNumber == Stop)
        {
            Console.WriteLine(Stop);
            return;
        }

        Console.WriteLine(CurrentNumber);
        find_natural_number(CurrentNumber + 1, Stop);
    }
}

class summ_natural_number
{
    public static void summ_natural_number_methods()
    {
        // Input user data
        Console.WriteLine("Enter first number:");
        int M = Convert.ToInt32(Console.ReadLine()); // first number 
        Console.WriteLine("Enter second number:");
        int N = Convert.ToInt32(Console.ReadLine()); // second number

        int result = find_summ_natural_number(M, N, 0);
        Console.WriteLine("Result: " + result);
    }

    private static int find_summ_natural_number(int CurrentNumber, int Stop, int Summ)
    {
        if (CurrentNumber == Stop)
        {
            return Summ + CurrentNumber;
        }
        return find_summ_natural_number(CurrentNumber + 1, Stop, Summ + CurrentNumber);
    }
}

class ackerman_functions
{
    public static void ackerman_functions_method()
    {
        // Input user data
        Console.WriteLine("Enter M number:");
        int M = Convert.ToInt32(Console.ReadLine()); // first number 
        Console.WriteLine("Enter N number:");
        int N = Convert.ToInt32(Console.ReadLine()); // second number
        // find_ackerman_functions
        int result = find_ackerman_functions(N, M);
        Console.WriteLine("Result: " + result);
    }

    static int find_ackerman_functions(int N, int M)
    {
        if (N == 0)
        {
            return M + 1;
        }
        else
        {
          if ((N != 0) && (M == 0))
          {
            return find_ackerman_functions(N - 1, 1);
          }
          else
          {
            return find_ackerman_functions(N - 1, find_ackerman_functions(N, M - 1));
          }
        }
    }
}