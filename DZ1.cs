// See https://aka.ms/new-console-template for more information
//onsole.WriteLine("Hello, World!");

// задача. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 

//Console.WriteLine("введите первое число");
//string num1 = Console.ReadLine()!;
//int num1int = int.Parse(num1);

//Console.WriteLine("Введите второе чсило");
//string num2 = Console.ReadLine()!;
//int num2int = int.Parse(num2);
//
//if (num1int > num2int)
//
//{
//    Console.WriteLine(num1int + "Больше" + num2int);
//}
//else if (num2int > num1int)
//{
//   Console.WriteLine(num2int + "Больше" + num1int);
//}

//else
//{
//    Console.WriteLine("числа равны");
//}


// задача. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//Console.WriteLine("Выедите целое число");
//string num1 = Console.ReadLine()!;
//int num1int = int.Parse(num1);
//
//if (num1int % 2 == 0)
//{
//    Console.WriteLine(num1int + "Число четное");
//}

//else
//{
//    Console.WriteLine(num1int + "Число не четное ");
//}

//задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Console.WriteLine("ведите первое число") ;
//string num1 = Console.ReadLine()!;
//int num1int= int.Parse(num1);


//Console.WriteLine("ведите второе число") ;
//string num2 = Console.ReadLine()!;
//int num2int= int.Parse(num2);


//Console.WriteLine("ведите третье число") ;
//string num3 = Console.ReadLine()!;
//int num3int= int.Parse(num3);

//if(num1int>num2int)
//{
//    if(num1int>num3int)
//    {
//        Console.WriteLine(num1int + "самое большое число");
//
//   }
//   else
//    {
//        Console.WriteLine(num3int +"самое большое число");
//    }
//}
//else
//{
//   if (num2int > num3int)
//   {
//     Console.WriteLine( num2int+ "самое большое число");
//
//  }
//else
//{
//    Console.WriteLine( num3int + "самое большео число");
//}
//}

//задача.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа

Console.WriteLine("введите целое число больше нууля");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

for (int i = 1; i < num1int; i++)

{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + "целое число");
    }
}