// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
//  Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
Sort(array);
Console.WriteLine();
PrintArray(array);



void FillArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-100,111);
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
        }
}

void Sort(int[,] array)
{
    for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = j + 1; k < cols; k++)
                {
                    if (array[i, j] > array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                for (int k = j + 1; k < rows; k++)
                {
                    if (array[j, i] > array[k, i])
                    {
                        int temp = array[j, i];
                        array[j, i] = array[k, i];
                        array[k, i] = temp;
                    }
                }
            }
        }
}