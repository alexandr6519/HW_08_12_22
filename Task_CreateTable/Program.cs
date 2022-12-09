//  Сгенерировать массив случайных целых чисел размерностью 
// m*n (размерность вводим с клавиатуры). Вывести на экран 
// красивенько таблицей. Найти минимальное число и его индекс,
// найти максимальное число и его индекс.
//   Вывести эту информацию на экран.

try
{
    Console.WriteLine("Input the first integer positive number for size of array");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the second integer positive number for another size of array");
    int m = Convert.ToInt32(Console.ReadLine());
    if (n < 1 || m < 1) Console.WriteLine("You should enter POSITIVE numbers only!");
    else
    {
        int[,] array = CreareAndFillRandomTwoDimensionalArray(n, m);
        PrintTwoDimensionalArray(array);
        Console.WriteLine("The maximum element {0} is in {1} row and in {2} column of the table", GetMaxOfArray(array)[0],GetMaxOfArray(array)[1] + 1, GetMaxOfArray(array)[2] + 1); 
        Console.WriteLine("The minimum element {0} is in {1} row and in {2} column of the table", GetMinOfArray(array)[0],GetMinOfArray(array)[1] + 1, GetMinOfArray(array)[2] + 1); 
    }
}
catch
{
    Console.WriteLine("You should enter number only!");
}

void PrintTwoDimensionalArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write(array[i, j].ToString().PadLeft(5));

        Console.WriteLine();
    }
}

int[,] CreareAndFillRandomTwoDimensionalArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            array[i, j] = new Random().Next(1, 201);
    }
    return array;
}

int[] GetMaxOfArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    int[] arrayMax = new int[3];
    arrayMax[0] = array[0, 0];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            if (array[i, j] > arrayMax[0])
            {
                arrayMax[0] = array[i, j];
                arrayMax[1] = i;
                arrayMax[2] = j;
            }
    }
    return arrayMax;
}

int[] GetMinOfArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    int[] arrayMin = new int[3];
    arrayMin[0] = array[0, 0];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            if (array[i, j] < arrayMin[0])
            {
                arrayMin[0] = array[i, j];
                arrayMin[1] = i;
                arrayMin[2] = j;
            }
    }
    return arrayMin;
}