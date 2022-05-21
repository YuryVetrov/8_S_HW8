// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
//Вывод:
//a[0, 0, 0] = 2
//a[0, 0, 1] = 4

void FillArray(int[, ,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
        {
            for (int k = 0;  k < array.GetLength(2);  k++)
            
            array[i, j, k] = count++; 
        }
    }
}
void PrintArray(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
        {
            for (int k = 0;  k < array.GetLength(2);  k++)
            System.Console.Write($"{array[i, j, k], 4}"); 
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void PrintIndex(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
        {
            for (int k = 0;  k < array.GetLength(2);  k++)
            System.Console.Write($"Число массива {array[i, j, k], 4}  имеет индексы: [{i}, {j}, {k}]. \n"); 
        }
    }
}
int[, ,] array = new int[3, 3, 3];
FillArray(array);
PrintArray(array);
PrintIndex(array);

