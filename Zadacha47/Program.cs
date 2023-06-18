Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int rows_count = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int colums_count = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows_count, colums_count];
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(-99, 99) / 10.0;
    }
}
Console.WriteLine($"Двумерный массив размером m×n:");
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i,j] + "\t");
    }
    Console.WriteLine();
}
