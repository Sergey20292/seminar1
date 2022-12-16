//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);

*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int digitFunction = Sumdigit(num);
Console.WriteLine(digitFunction);

int Sumdigit(int number)
{
    int sum = 0;
    while (number >= 10)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum + number;
}
*/


// Задача 29: Напишите программу, которая принимает на вход числа n, min, max. Затем генерирует массив размером n и заполняет его случайными числами

Console.WriteLine("Введите число n");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число min");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число max");
int max = int.Parse(Console.ReadLine()!);

int[] array = new int[num];

FillArray(array);
PrintArray(array);


void FillArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] frray)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}