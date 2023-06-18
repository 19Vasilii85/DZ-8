Console.Clear();
Console.WriteLine("После нажатие кнопки \"Enter\", будут создана трехмерная матрица из неповторяющихся двузначных чисел, поехали?");
Console.ReadLine();

//Создаем трехмерную матрицу
int[,,] numbers = new int[2, 2, 2];

// Функция заполнения трехмерной матрицы неповторяющимися числами
void FillArrayNonRecurringNumber(int[,,] array)
{
    int count = new Random().Next(10, 80);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 1;
            }
        }
    }
}

//Заполняем данными трехмерную матрицу
FillArrayNonRecurringNumber(numbers);

//Функция вывода трехмерной матрицы и индекса элементов её
void showThreeDimensionalMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

//Выводим трехмерную матрицу
Console.WriteLine("Трехмерная матрица содержит вот такие данные с их индексами:");
showThreeDimensionalMatrix(numbers);
