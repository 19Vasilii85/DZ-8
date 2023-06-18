Console.Clear();
Console.WriteLine("После нажатие кнопки \"Enter\", будут созданы две матрицы и будет найдено произведение этих матриц, поехали?");
Console.ReadLine();

//Функция заполнения двумерного массива данными
void FillArrayRandomNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 99);
        }
    }
}

//Создаем два двумерных массива
int[,] matrix_1 = new int[2, 2];
int[,] matrix_2 = new int[2, 2];
int[,] resultArray = new int[matrix_1.GetLength(0), matrix_1.GetLength(1)];

//Заполняем данными массивы
FillArrayRandomNumber(matrix_1);
FillArrayRandomNumber(matrix_2);

//Функция найхождения произведение двух матриц
void multiplicationMatrix(int[,] array_1, int[,] array_2)
{
    int[,] result = new int[array_1.GetLength(0), array_1.GetLength(1)];
    for (int i = 0; i < array_1.GetLength(0); i++)
    {
        for (int j = 0; j < array_2.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < array_1.GetLength(1); k++)
            {
                result[i, j] += array_1[i, k] * array_2[k, j];
            }
        }
    }
    resultArray = result;
}

//Функция вывода двумерного массива 
void showArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Сравниваем две матрицы с последующим нахождением произведения их
if (matrix_1.GetLength(0) != matrix_2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить матрицы, так как они не равны");
    return;
}
else
{
    multiplicationMatrix(matrix_1, matrix_2);
    Console.WriteLine("Первая матрица содержит данные:");
    showArray(matrix_1);
    Console.WriteLine("Вторая матрица содержит данные:");
    showArray(matrix_2);
    Console.WriteLine("Из полученных матриц получилась матрица прроизведения их, которая содержит данные:");
    showArray(resultArray);
}

