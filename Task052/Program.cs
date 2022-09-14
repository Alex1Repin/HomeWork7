//Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] SumNumbers(int[,] arr)
{
    var result = new  double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[i, j];
        }
        result[i] = Math.Round(sum / arr.GetLength(0), 2);
    }

    return result;
}

foreach(var item in SumNumbers(Numbers(rows, columns)))
{
    Console.WriteLine(item);
}
