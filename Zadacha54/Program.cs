Console.Clear();
Console.WriteLine("После нажатие кнопки \"Enter\", будет создан двумерный массив и отсортирован по убыванию, поехали?");
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
//Сортиуем двумерный массив по убыванию
for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int item = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = item;
                }
            }
        }
    }
Console.WriteLine("Отсортированный двумерный массив по убыванию:");
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i,j] + "\t");
    }
    Console.WriteLine();
}