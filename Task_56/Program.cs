// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//9 9 9
//1 1 1
//5 6 7
//-> вторая строка

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
void MinNum(int[] arr)
{
    int index = 0;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];  
            index = i; 
        }
    }
    Console.WriteLine($"Строка с индексом {index} имеет минимальную сумму {min} ");
    
    System.Console.WriteLine();
    //return arr[i];
}
void SearchMinSum(int[,] array, int[] arr)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        int sum = 0;
        for (int j = 0;  j < array.GetLength(1); j++) 
        {
            sum = sum + array[i, j];
        }
        arr[i] = sum;
    } 
}
int N = 3;
int[,] array = new int[N, 4];
int[] arr = new int [N];
FillArray(array);
PrintArray(array);
SearchMinSum(array, arr);
MinNum(arr);
