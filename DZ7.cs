//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
using System;

namespace task47
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("введите количество строк");
 	        int linesVol = Convert.ToInt32(Console.ReadLine());
 	        Console.WriteLine("введите количество столбцов");
 	        int columnsVol = Convert.ToInt32(Console.ReadLine());
 	        double[,] numbers = new double[linesVol, columnsVol];
 	        FillArrayRandomNumbers(numbers);
 	        PrintArray(numbers);
 	 
 	        void FillArrayRandomNumbers(double[,] array)
 	        {
 	        for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                    array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                    }
                }
            }
 	 
         	    void PrintArray(double[,] array)
            {
            for (int i = 0; i < array.GetLength(0); i++)
            {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
            Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
            }
            }
        }
    }
}

*/
//задпча 50


/*
int n = 0;
int m = 0;

Console.Write("Введите колличество строк: ");
bool parseIsOkN = int.TryParse(Console.ReadLine(), out int numberN);
if (!parseIsOkN)
{
    Console.WriteLine("Введено не коректное значение!");
    return;
}
else
    n = numberN;

Console.Write("Введите колличество столбцов: ");
bool parseIsOkM = int.TryParse(Console.ReadLine(), out int numberM);
if (!parseIsOkM)
{
    Console.WriteLine("Введено не коректное значение!");
    return;
}
else
    m = numberM;


//Заполняем массив рандомно 
int[,] getFillArray(int n, int m)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(0, 20); //Задаем диапазон 
        }
    }
    return array;
}

//Выводим наш массив для просмотра
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] array = getFillArray(n, m);
printArray(array);

Console.Write("Введите индекс строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

//Метод проверки и вывода числа на заданной позиции
void checkPosition(int[,] array, int a, int b)
{
    if (a > array.GetLength(0) || b > array.GetLength(1))
        Console.WriteLine("Позиция находится за пределами массива");
    else
    {
        Console.WriteLine($"Элемент на позиции [{a},{b}] - {array[a, b]}");
    }
}
checkPosition(array, a, b);
*/
//задача 52

int n = 0;
int m = 0;

Console.Write("Введите колличество строк: ");
bool parseIsOkN = int.TryParse(Console.ReadLine(), out int numberN);
if (!parseIsOkN)
{
    Console.WriteLine("Введено не коректное значение!");
    return;
}
else
    n = numberN;

Console.Write("Введите колличество столбцов: ");
bool parseIsOkM = int.TryParse(Console.ReadLine(), out int numberM);
if (!parseIsOkM)
{
    Console.WriteLine("Введено не коректное значение!");
    return;
}
else
    m = numberM;


//Заполняем массив рандомно 
int[,] getFillArray(int n, int m)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(0, 20); //Задаем диапазон 
        }
    }
    return array;
}

//Выводим наш массив для просмотра
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] array = getFillArray(n, m);
printArray(array);

//Развернули массив 
int[,] Rotate(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    int[,] result = new int[m, n];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            result[j, n - i - 1] = array[i, j];
    return result;
}
int[,] arrayNew = Rotate(array); //Новый массив

//Выводим среднее арифметическое столбца 
void printAverage(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {i}: {sum / array.GetLength(1)}");
    }

}
printAverage(arrayNew);