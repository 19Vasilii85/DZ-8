Console.Clear();
Console.WriteLine("После нажатие кнопки \"Enter\", будет создан двумерный массив и найдена строка с наименьшей суммой строки двумерного массива, поехали?");
Console.ReadLine();
//Создаем двумерный массив
int[,] numbers = new int[3, 4];
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 99);
    }
}
Console.WriteLine($"Создан двумерный массив:");
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i,j] + "\t");
    }
    Console.WriteLine();
}

//Находим строку с наименьшей суммой строки двумерного массива
int minRow = 0;
int minSumRow = 0;
int sumRow = 0;
for (int i = 0; i < numbers.GetLength(1); i++)
{
    minRow += numbers[0, i];
}
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sumRow += numbers[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    } 
}
Console.Write($"Строка с наименьшей суммой равна: {minSumRow + 1}");