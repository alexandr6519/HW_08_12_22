// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
try
{
    Console.WriteLine("Enter 4 any real numbers as line equation coefficients");
    string? text = Console.ReadLine();
    if (text == null)
    {
        Console.WriteLine("You entered empty line!");
    }
    else
    {
        string[] substring = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (substring.Length != 4)
            Console.WriteLine("You should enter 4 numbers exactly!");
        else
        {
            double[] numbers = new double[4];

            for (int i = 0; i < 4; i++)
                numbers[i] = Convert.ToDouble(substring[i]);

            if (numbers[0] < 0)
                Console.WriteLine("The first line equation is: y = {0} * x - {1}", numbers[1], Math.Abs(numbers[0]));
            else Console.WriteLine("The first line equation is: y = {0} * x + {1}", numbers[1], numbers[0]);
            if (numbers[2] < 0)
                Console.WriteLine("The second line equation is: y = {0} * x - {1}", numbers[3], Math.Abs(numbers[2]));
            else Console.WriteLine("The second line equation is: y = {0} * x + {1}", numbers[3], numbers[2]);

            double[] point = GetIntersectionOfLines(numbers[0], numbers[1], numbers[2], numbers[3]);
            if (point.Length == 2)
                Console.WriteLine("The point of intersection of this lines is: ({0:f1}; {1:f1})", point[0], point[1]);
            else if (numbers[0] == numbers[2]) Console.WriteLine("The lines coincide!");
            else Console.WriteLine("The lines do NOT intersect!");
        }
    }
}
catch
{
    Console.WriteLine("You should enter numbers only!");
}

double[] GetIntersectionOfLines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) return new double[0];
    double temp = (b2 - b1) / (k1 - k2);
    double[] point = new double[2];
    point[0] = temp;
    point[1] = k2 * temp + b2;
    return point;
}