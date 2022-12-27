//задача 54
/*
void fillMatrixWithRandomPositiveIntegers(int[,] matrix)
{
 Random rnd = new Random();
 for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
 for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
 matrix[rowIndex, columnIndex] = rnd.Next(0, 10);
        }
    }
}

void printMatrixOfIntegersToConsole(int[,] matrix)
{
 for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
 Console.Write("\n");
 for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
 Console.Write($" {matrix[rowIndex, columnIndex]}");
        }
    }
    Console.Write("\n");
}

Console.WriteLine("Введите количество строк матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
 Console.WriteLine("Некорректные значения");
}
else
{
 int[,] matrix = new int[m, n];
 fillMatrixWithRandomPositiveIntegers(matrix);
 printMatrixOfIntegersToConsole(matrix);

 // insertion sort
 for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        int columnCount = matrix.GetLength(1);
        if (columnCount < 2)
        {
            break;
        }
        if (matrix[rowIndex, 0] < matrix[rowIndex, 1])
        {
            int temp = matrix[rowIndex, 0];
            matrix[rowIndex, 0] = matrix[rowIndex, 1];
            matrix[rowIndex, 1] = temp;
        }
        for (int unsorted = 2; unsorted < columnCount; unsorted++)
        {
            for (int sorted = 0; sorted < unsorted; sorted++)
            {
                if (matrix[rowIndex, unsorted] > matrix[rowIndex, sorted])
                {
                    int temp = matrix[rowIndex, unsorted];
                    matrix[rowIndex, unsorted] = matrix[rowIndex, sorted];
                    matrix[rowIndex, sorted] = temp;
                }
            }
        }
    }
    Console.WriteLine("Матрица отсортированных строк:");
    printMatrixOfIntegersToConsole(matrix);
}

*/
//задача56

/*
int[,] newArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(-9, 10);
        }
    }
    return result;
}

void showArray(int[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            System.Console.Write($"{input[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[] findMaxString(int[,] array)
{
    int[] result = new int[2];
    int minSum = 0;
    int minStr = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum+= array[0,j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minStr = i;
        }
    }
    result[0] = minStr + 1;
    result[1] = minSum;
    return result;
}

System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = newArray(m, n);
showArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Строка {findMaxString(array)[0]} является строкой с наименьшей суммой элементов: {findMaxString(array)[1]}");
*/
//задача58

/*
int[,] newArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void showArray(int[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            System.Console.Write($"{input[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

bool checkSoglasovannost(int[,] arr1, int[,] arr2)
{
    return arr1.GetLength(1) == arr2.GetLength(0);
}

int[,] matrixMulti(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int N = 0; N < arr1.GetLength(1); N++)
            {
                result[i,j] += arr1[i, N] * arr2[N, j];
            }
        }
    }
    return result;
}

Console.Clear();

System.Console.Write("Введите количество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество строк второй матрицы: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов второй матрицы: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[,] array1 = newArray(m, n);
int[,] array2 = newArray(x, y);
showArray(array1);
System.Console.WriteLine();
showArray(array2);
System.Console.WriteLine();
if(checkSoglasovannost(array1, array2)) showArray(matrixMulti(array1,array2));
else System.Console.WriteLine("Матрицы несогласованны!");

*/
//задача60
/*

bool Contains(int[] array, int a)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a) return true;
    }
    return false;
}

int[] twoNumbersMassiv(int len)
{
    int[] result = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        int b = rnd.Next(10, 100);
        if (Contains(result, b)) i--;
        else result[i] = b;
    }
    return result;
}

int[,,] trexmernMatrix(int x, int y, int z, int[] array)
{
    int[,,] result = new int[x, y, z];
    int count = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = array[count];
                count++;
            }
        }
    }
    return result;
}

void showArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                System.Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}

System.Console.Write("Введите длинну массива по координате X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите длинну массива по координате Y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите длинну массива по координате Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[] helpArray = twoNumbersMassiv(x*y*z);
showArray(trexmernMatrix(x, y, z, helpArray));

*/





