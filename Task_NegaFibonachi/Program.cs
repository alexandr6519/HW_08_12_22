// На вход программы подаются одно целое число. Составьте 
// список чисел Фибоначчи, в том числе для отрицательных индексов. 
//  Это по сути последовательность Негафибоначчи.
// Пример: для k = 8 список будет выглядеть так: 
//[-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
Console.WriteLine("Input the integer positive number, please");
try
{
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("You should enter POSITIVE number only!");
else
{
    int[] arrayPositiveFibonachi = GetSiquenceFibonachi(number);
    PrintArray(arrayPositiveFibonachi);
    int[] arrayNegativeFibonachi = GetSiquenceNegativeFibonachi(number);
    PrintArray(arrayNegativeFibonachi);
    int[] arrayFibonachi = JoinArrays(arrayNegativeFibonachi, arrayPositiveFibonachi);
    PrintArray(arrayFibonachi);
}
}
catch
{
    Console.WriteLine("You should enter number only!");
}

int GetNumberFibonachi(int n)
{
    if (n == 1 || n == 2) return 1;
    int result = 2;
    int currentElement = 2;
    int previousElement = 1;

    for (int i = 3; i < n; i++)
    {
        currentElement = result;
        result += previousElement;
        previousElement = currentElement;
    }
    return result;
}

int GetNumberNegativeFibonachi(int n)
{
    if (n == 1) return 1;
    if (n == 2) return -1;
    int result = 2;
    int currentElement = 2;
    int previousElement = -1;

    for (int i = 2; i < n; i++)
    {
        currentElement = result;
        result = previousElement - result;
        previousElement = currentElement;
    }
    return result;
}

int[] GetSiquenceFibonachi(int n)
{
    if (n == 0) return new int[1] { 0 };
    if (n == 1) return new int[2] { 0, 1 };
    if (n == 2) return new int[3] { 0, 1, 1 };
    int[] arrayPositiveFibonachi = new int[n + 1];
    arrayPositiveFibonachi[0] = 0;
    arrayPositiveFibonachi[1] = 1;
    arrayPositiveFibonachi[2] = 1;
    for (int i = 3; i <= n; i++)
        arrayPositiveFibonachi[i] = GetNumberFibonachi(i);

    return arrayPositiveFibonachi;
}

int[] GetSiquenceNegativeFibonachi(int n)
{
    if (n == 1)
        return new int[1] { 1 };
    if (n == 2)
        return new int[2] { 1, -1 };
    int[] arrayNegativeFibonachi = new int[n];
    arrayNegativeFibonachi[0] = 1;
    arrayNegativeFibonachi[1] = -1;
    arrayNegativeFibonachi[2] = 2;
    for (int i = 3; i < n; i++)
        arrayNegativeFibonachi[i] = GetNumberNegativeFibonachi(i);

    return arrayNegativeFibonachi;
}

int[] JoinArrays(int[] a1, int[] a2)
{
    int size1 = a1.Length;
    int size2 = a2.Length;
    int[] arrayJoining = new int[size1 + size2];
    for (int i = 0; i < size1; i++)
        arrayJoining[i] = a1[size1 - 1 - i];
    for (int i = size1; i < size2 + size1; i++)
        arrayJoining[i] = a2[i - size1];
    return arrayJoining;
}

void PrintArray(int[] array)
{
    if (array.Length > 0) Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($" {array[i]},");
        else Console.Write($" {array[i]})");
    }
    Console.WriteLine();
}