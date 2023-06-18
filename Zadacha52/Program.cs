Console.Clear();
Console.WriteLine("После нажатия кнопки \"Enter\", будет создан двумерный массив и подсчитаны среднее арифметическое элементов в каждом столбце, поехали?");
Console.ReadLine();
int[,] numbers = new int[3, 4];
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 16);
    }
}
Console.WriteLine($"Двумерный массив:");
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i,j] + "\t");
    }
    Console.WriteLine("");
}
double[] avgNumbers = new double[numbers.GetLength(1)];
for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}
for (int i = 0; i < avgNumbers.Length; i++)
{
    Console.Write($"Среднее арифметическое, {i} столбца, равно: {avgNumbers[i] + " "}\n");
}
