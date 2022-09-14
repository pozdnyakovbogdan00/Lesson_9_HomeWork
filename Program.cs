int Answer = Program_Main_InputData();

switch (Answer)
{
    case 1: natural_numbers.natural_numbers_metod(); break;  
    case 2: summ_natural_number.summ_natural_number_methods(); break;
    case 3: ackerman_functions.ackerman_functions_method(); break;
    default: Console.WriteLine("You have entered an invalid value (Enter 1 - 3)."); break;
}

// START Procedures and functions

static int Program_Main_InputData()
{
    Console.WriteLine("Choose one of the suggested values: ");
    Console.WriteLine("1: Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
    Console.WriteLine("2: Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("3: Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    Console.WriteLine("Your choice? ");
    int InputData = Convert.ToInt32(Console.ReadLine());
    
    return InputData; 
}

// END Procedures and functions
