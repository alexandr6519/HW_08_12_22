//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
try
{
    Console.WriteLine("Enter any numbers");
    string? text = Console.ReadLine();
    if (text == null)
    {
        Console.WriteLine("You entered empty line!");
    }
    else
    {
        string[] substring = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        double[] numbers = new double[substring.Length];

        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = Convert.ToDouble(substring[i]);

        Console.WriteLine("This is list of numbers of user: ");
        PrintArrayDouble(numbers);
        Console.WriteLine("The count of positive numbers from this list of user is: {0}", CountPositiveNumbers(numbers));
    }
}
catch
{
    Console.WriteLine("You should enter numbers only!");
}
void PrintArrayDouble(double[] array)
{
    if (array.Length > 0) Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write("{0:f2}; ", array[i]);
        else Console.Write("{0:f2})", array[i]);
    }
   Console.WriteLine();
}

int CountPositiveNumbers(double [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    if (array[i] > 0) count++;
    return count;
}