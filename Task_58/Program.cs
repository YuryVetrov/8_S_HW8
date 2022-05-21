// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.
//Пример скоро будет.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
            array[i, j] = new Random().Next(1, 100);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
            System.Console.Write($"{array[i, j], 4}"); 
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void MultArray(int[,] array1, int[,] array2, int[,] result)
{
    for (int i = 0; i < array1.GetLength(0); i++) // цикл для матрицы строк
    {
        for (int j = 0;  j < array1.GetLength(1);  j++) //// цикл для матрицы столбцов
        {
            result[i, j] = 0;
            for (int k = 0;  k < array1.GetLength(1);  k++) 
            {
                result[i, j] += array1[i, k] * array2[k, j];

            }
        }
    }
}
int N = 4;
int[,] array1 = new int[N, N];
int[,] array2 = new int[N, N];
int[,] result = new int[N, N];
FillArray(array1);
FillArray(array2);
PrintArray(array1);
PrintArray(array2);
MultArray(array1, array2, result);
System.Console.WriteLine("Произведением двух данных матриц будет являться:");
PrintArray(result);
