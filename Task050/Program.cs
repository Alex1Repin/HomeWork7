//Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//вводим позиции по i и j -> если таких нет - выводим,
// что позиции не существует. Если есть - выводим элемент по 
//этим индексам.

int rows = 3;
int columns = 4;

int[,] Numbers(int m, int n)
{
    var result = new int[m, n]; 
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(100);
        }
    }
    return result;
}
bool Contains(int[,] arr, int elements)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == elements) return true;
        }
    }
    return false;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}


var arr = Numbers(rows, columns);
PrintArray (arr);
Console.WriteLine(Contains(arr, 56));
