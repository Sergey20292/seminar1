//задача 34
/*
int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных числа");
}
else

    Console.WriteLine($"В массиве {result} четных чисел");

// Методы
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
Console.Write("Массив из скольки элементов требуется сгенерировать? ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine(Method(n, min, max));
int Method(int size, int mn, int mx)
{
    int x = 0;
    int[] array = new int[size];
    Random random = new Random();
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(mn, mx + 1);
        Console.Write($"{array[i]} ");
        if (i % 2 != 0)
            x += array[i];
    }
    Console.Write("] -> ");
    return x;
}
*/
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()
// [3 7 22 2 78] -> 76

Console.Write("Массив из скольки элементов требуется сгенерировать? ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine(Method(n, min, max));
int Method(int size, int mn, int mx)
{
    int result, mxel = mn, mnel = mx;
    int[] array = new int[size];
    Random random = new Random();
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(mn, mx + 1);
        if (array[i] > mxel)
            mxel = array[i];
        if (array[i] < mnel)
            mnel = array[i];
        Console.Write($"{array[i]} ");
    }
    Console.Write("] -> ");
    result = mxel - mnel;
    return result;
}