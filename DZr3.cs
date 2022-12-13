// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*задача 19
Console.WriteLine("Введите пятизначное число:");
int n = Math.Abs(int.Parse(Console.ReadLine()!));

int[] array = new int[5];

for (int i = 0; i <= 4; i++)
{
    array[i] = n % 10;
    n = n / 10; 
}
if (array[0] == array[4] && array[1]== array[3])
{
    Console.WriteLine("Число является полиндроном");
}
else
{
    Console.WriteLine("Число неявляется полиндроном");
}
*/

/* задача 21

Console.WriteLine("Введите координату X точки A");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки A");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки A");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X точки B");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки B");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки B");
int z2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)));
*/

//Задача 23


int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}



// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


