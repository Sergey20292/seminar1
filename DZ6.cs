//задача 41
 
 /*
 double[] mapToInt(string[] strings)
{
    double[] numbers = new double[strings.Length];

    for (int i = 0; i < strings.Length; i++)
    {
        numbers[i] = Convert.ToDouble(strings[i]);
    }

    return numbers;
}

int countPositive(double[] numbers)
{
    int count = 0;
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine("Введите некоторое количаство(М) чисел, разделяя их пробелами");

string[] strNumbers = Console.ReadLine().Split(" ");

try
{
    double[] numbers = mapToInt(strNumbers);
    Console.WriteLine("Количество чисел больше 0: " + countPositive(numbers));
}
catch (Exception )
{
    Console.WriteLine("Некорректное значение");
}
*/

//задача 43

double calculateY(double x, double k, double b)
{
    return (k * x) + b;
}

/*
* Аналитически удалось вычислить, что 
* точка пересечения двух прямых буквально означает:
* 
* x1 = x2
* y1 = y2
*
* Тогда:
*
* k1 * x + b1 = k2 * x + b2
* (k1 * x) - (k2 * x) = b2 - b1
* x * (k1 - k2) = b2 - b1
* x = (b2 - b1) / (k1 - k2)
* y = k1 * x + b1 
*/

double findCrossingX(double k1, double b1, double k2, double b2)
{
    return (b2 - b2) / (k1 - k2);
}

Console.WriteLine("Введите коэффициент наклона первой линии, k1:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите слагаемое первой линии, b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэффициент наклона второй линии, k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите слагаемое второй линии, b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2) // пренебрегаю здесь фактором точности чисел с плавающей точкой
{
    Console.WriteLine("Линии параллельны");
}
else
{
    double crossingX = findCrossingX(k1, b1, k2, b2);
    double crossingY = calculateY(crossingX, k1, b1);

    Console.WriteLine($"Точка пересечения имеет координаты {String.Format("{0:F2}", crossingX)} {String.Format("{0:F2}", crossingY)}");
}
