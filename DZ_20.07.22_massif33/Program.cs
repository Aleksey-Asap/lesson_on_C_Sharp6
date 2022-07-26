// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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

// Random random = new Random();

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         mass[i, j] = random.Next(1, 20);
//     }
// }
// Print(mass);
// Console.WriteLine();

// Console.WriteLine(": ");
// for (int i = 0; i < m; i++)
// {
//     for (int r = 0; r < n; r++)
//     {
//         for (int j = 0; j < n - 1; j++)
//         {
//             if (mass[i, j] < mass[i, j + 1])
//             {
//                 int a = mass[i, j + 1];
//                 mass[i, j + 1] = mass[i, j];
//                 mass[i, j] = a;
//             }
//         }
//     }

//     // Array.Sort(mass[i], (a, b) => b.CompareTo(a)); // Sort - изначально сортирует по возврастанию, b.CompareTO - сравнение числа a, b - больше.
// }

// Print(mass);


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

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

// Random random = new Random();

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         mass[i, j] = random.Next(1, 20);
//     }
// }
// Print(mass);
// Console.WriteLine();

// Console.WriteLine(": ");
// int minNumRow = -1;
// int minSumRow = 0;

// for (int i = 0; i < m; i++)
// {
//     int sum = 0;
//     for (int j = 0; j < n; j++)
//     {
//         sum += mass[i, j];
//     }

//     if (minNumRow == -1)
//     {
//         minSumRow = sum;
//         minNumRow = 0;
//         continue; // пропустить итерацию
//     }

//     if ( sum < minSumRow)
//     {
//         minSumRow = sum;
//         minNumRow = i;
//     }
// }

// for (int j = 0; j < n; j++)
// {
//     Console.Write(mass[minNumRow, j] + ", ");
// }

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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
// int m = 3, n = 4, k = 4;
// int[,] mass = new int[m, k];

// Random random = new Random();

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         mass[i, j] = random.Next(1, 20);
//     }
// }
// Print(mass);
// Console.WriteLine();

// int[,] mass2 = new int[k, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         mass2[i, j] = random.Next(1, 20);
//     }
// }
// Print(mass2);
// Console.WriteLine();


// int[,] r = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         for (int l = 0; l < m; l++)
//         {
//             r[i,j] += mass[i,l] * mass2[l,j];
//         }
//     }
// }

// Print(r);

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, 
// добавляя индексы каждого элемента.

// void Print(int[,,] arr)
// {
//     for (int x = 0; x < arr.GetLength(0); x++)
//     {
//         for (int y = 0; y < arr.GetLength(1); y++)
//         {
//             Console.Write($"x({x}) y({y}) ");
//             for (int z = 0; z < arr.GetLength(2); z++)
//             {
//                 Console.Write($"z({z}): {arr[x, y, z]} ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }
// int m = 3, n = 4, k = 4;
// int[,,] mass = new int[m, n, k];
// int[] numbers = new int[m * n * k];
// Random random = new Random();

// // Формируем числа для трехмерного массива
// for (int i = 0; i < numbers.Length; i++)
// {
//     int number = random.Next(10, 100);
//     if (numbers.Contains(number)) // Contains - содержит
//     {
//         while (numbers.Contains(number))
//         {
//             number = random.Next(10, 100);
//         }
//     }
//     numbers[i] = number;
// }

// int count = 0;
// for (int x = 0; x < m; x++)
// {
//     for (int y = 0; y < n; y++)
//     {
//         for (int z = 0; z < k; z++)
//         {
//             mass[x, y, z] = numbers[count];
//             count++;
//         }
//     }
// }
// Print(mass);
// Console.WriteLine();




// Задача 62: Заполните спирально массив 4 на 4.

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
int m = 4, n = 4;
int[,] mass = new int[m, n];
int number = 1;

int i =0;
int j =0;

while (number<= m*n)
{
    mass[i,j] = number;
    number++;
}
Print(mass);
Console.WriteLine();

