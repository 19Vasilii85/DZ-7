Console.Clear();
Console.WriteLine("Введите элемент строки массива: ");
int row_item = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите элемент столбца массива: ");
int colum_item= Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[3, 4];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 16);
    }
}
if (row_item < numbers.GetLength(0) && colum_item < numbers.GetLength(1)){
    Console.WriteLine($"Значение элемента: [{row_item } : {colum_item}] равно: {numbers[row_item, colum_item]}, в массиве:");
} 
else{
    Console.WriteLine($"Элемента: [{row_item } : {colum_item}], нет в массиве:");
}
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i,j] + "\t");
    }
    Console.WriteLine();
}