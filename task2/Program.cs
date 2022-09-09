// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//functions
int[,] GetArray(int m, int n, int min , int max)
{
    int[,] result = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] DoReverse(int[,] array, int rows, int columns)
{
    if (rows != columns)
    {
        Console.WriteLine("zzz");
        return array;
    }
    int[,] arrayL = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayL[j,i] = array[i,j];
        }
    }
    return arrayL;
}
// void DoReverse(int[,] array)
// {
    
//      for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//          {
            
//             int k = array[i,j];
//             array[i,j] = array[j,i];
//             array[j,i] = k;
            
            
//         }
//     }
   
// }
//code


int[,] array = GetArray(3,3,1,9);
PrintArray(array);
Console.WriteLine("");
array = DoReverse(array,3,3);
PrintArray(array);
