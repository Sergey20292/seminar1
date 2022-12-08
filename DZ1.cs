
//   задача.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трехзначное число");
int num1 = int.Parse(Console.ReadLine()!);
if ((num1 >= 100) && (num1 < 1000))
{
    int firstDigit = num1 % 100;
    int secondDigit = firstDigit / 10;
    Console.WriteLine(secondDigit);

}
else
{
    Console.WriteLine("Введено не трехзначное число");
}
*/

// задача.Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Введите номер дня недели(1-7)");
int num1 = int.Parse(Console.ReadLine()!); 

if (num1>0&& num1<8)

{
    if(num1==6 || num1 ==7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будни");
    }
}
else
{
    Console.WriteLine("число выходящие из диопазона 1 до 7 ");

}
*/


int number = ReadInt("Введите число");
int count = number.ToString()!.Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет,");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}


