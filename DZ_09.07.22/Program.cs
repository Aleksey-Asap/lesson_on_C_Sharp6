// Задача 46: Задайте двумерный массив размером 
// m×n, заполненный  случайными вещественными числами.
// m = 3, n = 4. 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void Print(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + ", ");
//         }
//         Console.WriteLine();
//     }
// }

// int m = 3, n = 4;
// double[,] mass = new double[m, n];

// for (int i = 0; i < mass.GetLength(0); i++)
// {
//     for (int j = 0; j < mass.GetLength(1); j++)
//     {
//         mass[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
//         mass[i, j] = Math.Round(mass[i, j], 2);
//     }
// }

// Print(mass);

// Задача 50: Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента
// или же указание, что такого элемента нет
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void Print(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + ", ");
//         }
//         Console.WriteLine();
//     }
// }

// int m = 3, n = 4;
// int[,] mass = new int[m, n];

// for (int i = 0; i < mass.GetLength(0); i++)
// {
//     for (int j = 0; j < mass.GetLength(1); j++)
//     {
//         mass[i, j] = i + j;
//     }
// }
// Print(mass);
// Console.WriteLine();

// Console.WriteLine("Введите первое число массива:");
// int k = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите введите второе число массива:");
// int t = int.Parse(Console.ReadLine());
// int[,] mass1 = new int[k, t];

// for (int i = 0; i < mass.GetLength(0); i++)
// {
//     for (int j = 0; j < mass.GetLength(1); i++)
//     {
//         if (mass[i, j] == mass1[k, t])
//         {
//             Console.WriteLine(mass[i, j]);
//         }
//         else Console.WriteLine("Такого значения нет");
//     }
// }

// Print(mass);









void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + ", ");
        }
        Console.WriteLine();
    }
}

int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = i + j;
    }
}

double sum1 = 0;
double sum2 = 0;
double sum3 = 0;
double sum4 = 0;
double ArithmeticSum1 = 0;
double ArithmeticSum2 = 0;
double ArithmeticSum3 = 0;
double ArithmeticSum4 = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{

    sum1 += mass[i, 0];
    ArithmeticSum1 = sum1 / m;
    sum2 += mass[i, 1];
    ArithmeticSum2 = sum2 / m;
    sum3 += mass[i, 2];
    ArithmeticSum3 = sum3 / m;
    sum4 += mass[i, 3];
    ArithmeticSum4 = sum4 / m;
}

Print(mass);
Console.WriteLine(" Cреднее арифметическое элементов в каждом столбце:");
Console.WriteLine($"{ArithmeticSum1}, {ArithmeticSum2}, {ArithmeticSum3}, {ArithmeticSum4}");



// for (int i=1,k=0;i<5;i+=2) 
// {
//     double summa=0;
//     for (int j=0;j<5;j++) 
//     {
//         summa+=a[i,j];
//     }
//     b[k]=summa/5;
//     Console.WriteLine("Среднее арифметическое столбца "+(i+1)+" равно: "+b[k]);