// // Задача 46: Задайте двумерный массив размером 
// // m×n, заполненный случайными целыми числами.
// // m = 3, n = 4. 
// // 1 4 8 19 
// // 5 -2 33 -2 
// // 77 3 8 1

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
//         mass[i, j] = new Random().Next(-100, 100);
//     }
// }

// Print(mass);

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4. 
// 0 1 2 3 
// 1 2 3 4 
// 2 3 4 5

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

// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4

// Новый массив будет выглядеть вот так: 
// 1 4 7 2 
// 5 81 2 9 
// 8 4 2 4

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

// for (int i = 0; i < mass.GetLength(0); i+=2)
// {
//     for (int j = 0; j < mass.GetLength(1); j+=2)
//     {
//         mass[i, j] = mass[i, j] * mass[i, j];
//     }
// }

// Print(mass);



// Задача 51: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.


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

// int sum = 0;

// for (int i = 0; i < Math.Min(mass.GetLength(0), mass.GetLength(1)); i++)
// {
//     sum += mass[i, i];
// }

// Print(mass);
// Console.WriteLine(sum);

