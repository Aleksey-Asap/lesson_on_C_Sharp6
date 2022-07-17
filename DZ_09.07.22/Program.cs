// Задача 47: Задайте двумерный массив размером 
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
// Random random = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         mass[i, j] = random.Next(-100, 100) + random.NextDouble();
//         mass[i, j] = Math.Round(mass[i, j], 2);
//     }
// }

// Print(mass);

// Задача 50: Напишите программу, которая 
// на вход принимает значение элемента в двумерном массиве, 
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

// Random random = new Random();
// int m = 3, n = 4;
// int[,] mass = new int[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         mass[i, j] = random.Next(1,20);
//     }
// }
// Print(mass);
// Console.WriteLine();

// Console.WriteLine("Введите значение числа массива:");
// int num = int.Parse(Console.ReadLine());


// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (mass[i, j] == num)
//         {
//             Console.WriteLine($"Строка {i}; Столбец {j}");
//             return;
//         }
//     }
// }
// Console.WriteLine("Такого значения нет");


// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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

// Random random = new Random();
// int m = 3, n = 4;
// int[,] mass = new int[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         mass[i, j] = random.Next(1, 20);
//     }
// }
// Print(mass);
// Console.WriteLine();

// Console.WriteLine("Среднее арифметическое каждого столбца: ");
// for (int j = 0; j < n; j++)
// {
//     double sum = 0;
//     for (int i = 0; i < m; i++)
//     {
//         sum += mass[i, j];
//     }
//     Console.Write(Math.Truncate(sum/m*10)/10 + "; ");
// }