//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
//6 4 1 9
//4 9 1 2
//->
//9 6 4 1
//9 4 2 1

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
void BubbleSort(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++) // цикл для матрицы строк
    {
        for (int j = 0;  j < array.GetLength(1);  j++) //// цикл для матрицы столбцов
        {
            for (int k = 0;  k < array.GetLength(1) -j -1;  k++) // цикл для сравнения и замены
            {
                if (array[i, k] < array[i, k + 1]) // замена элементов
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k +1] = temp;
                }
            }
        }
    }
    //return temp;
}

int[,] array = new int[5, 6];
FillArray(array);
PrintArray(array);
BubbleSort(array);
PrintArray(array);
