Console.Clear();
Console.WriteLine("После нажатие кнопки \"Enter\", будет создан двумерный массив 4х4, который будет заполнит спирально, поехали?");
Console.ReadLine();

int count_item = 4;

//Создаем двумерный массив
int[,] numbers = new int[count_item, count_item];

//Функция заполнения массива по спирали
void FillArraySpiralNumber(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do 
        { 
            array[i, j++] = value++; 
        }
        while (++k < n - 1);
        {
            for (k = 0; k < n - 1; k++)
            {
                array[i++, j] = value++;
            } 
            for (k = 0; k < n - 1; k++){
                array[i, j--] = value++;
            }
            for (k = 0; k < n - 1; k++){
                array[i--, j] = value++;
            }
            ++i; ++j;
            n = n < 2 ? 0 : n - 2;
        }
    }
}

//Заполняем массив спирально
FillArraySpiralNumber(numbers, count_item);

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

//Выводим двумерный массив заполненный спирально
Console.WriteLine("Двумерный массив заполненный спирально, которая содержит данные:");
showArray(numbers);
