//Задача 68:
System.Console.WriteLine($"Akker(0, 0) = {Akker()}");
System.Console.WriteLine($"Akker(1, 2) = {Akker(1, 2)}");
System.Console.WriteLine($"Akker(2, 3) = {Akker(2, 3)}");
System.Console.WriteLine($"Akker(3, 2) = {Akker(3, 2)}");

// Вычисления Akker(4, 3) вряд ли дождемся
double Akker(double m = 0, double n = 0)
{
    if (m < 0 || n < 0) { System.Console.WriteLine("Неверное условие"); return -1; }

    double AkkerValue;
    if (m == 0) return n + 1;

    if (m > 0 && n == 0)
    {
        AkkerValue = Akker(m - 1, 1);
        return AkkerValue;
    }

    AkkerValue = Akker(m - 1, Akker(m, n - 1));
    return AkkerValue;
}

//задача66


(int start, int finish) range = (new Random().Next(-20, 0), new Random().Next(0, 21));
System.Console.WriteLine($"Сумма натуральных в диапазоне с {range.start} по {range.finish} = {recurs(range)}");


long recurs((int start, int finish) range, long Snatural = 0)
{
    if(range.start > 0) Snatural += range.start;
    range.start += 1;
    if (range.start > range.finish) return Snatural;
    return recurs(range, Snatural);
}

//задача 64

Console.Clear();

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int N = EnterNumber("Введите натуральное число N");

int PrintNumbers (int number)
{
    if (number > 1)
    {
        Console.Write(number + " ");
        PrintNumbers(number - 1);
    }
    return 1;
}
Console.WriteLine(PrintNumbers(N));