// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.) 
// [1 2 3 4 5] -> [5 4 3 2 1] 
// [6 7 3 6] -> [6 3 7 6]

// int[] mass = new int[10];
// for (int i = 0; i < mass.Length; i++)
// {
//     mass[i] = new Random().Next(1, 10);
// }
// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }
// Print(mass);

// for (int i = 0; i < mass.Length / 2; i++)
// {
//     int save = mass[i];
//     mass[i] = mass[mass.Length - 1 - i];
//     mass[mass.Length - 1 - i] = save;
// }

// Print(mass);
// // for (int i = 0; i < mass.Length; i++)
// // {
// //     Console.Write(mass[i] + " ");
// // }
// // Console.WriteLine();


// Задача 40: Напишите программу, которая принимает 
// на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите x:");
// int x = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите y:");
// int y = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите z:");
// int z = int.Parse(Console.ReadLine());

// if ((x < (y + z)) && (y < (x + z)) && (z < (x + y)))
// {
//     Console.WriteLine("Треугольник, может существовать с сторонами такой длины");
// }
// else Console.WriteLine("Треугольник, не может существовать с сторонами такой длины");




// Способ 1. Задача 42: Напишите программу, которая 
// будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 
// 3  -> 11 
// 2  -> 10
//
// void Number(int a,  int j)
// {
//     int[] A = new int[j];
//     int index = 0;
//     while (a > 0)
//     {
//         A[index] = a % 2;
//         index++;
//         a = a / 2;
//     } 
//     for (int i = A.Length - 1; i >= 0; i--)
//     {
//         Console.Write($"{A[i]}");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());
// int j = 0;
// int p = number;
// while (number > 0)
// {
// number = number / 2;
// j++;
// }
// Number(p, j);


// Способ 2. Задача 42: Напишите программу, которая 
// будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 
// 3  -> 11 
// 2  -> 10
//
// Console.WriteLine("Введите десятичное число: ");
// int numb10 = int.Parse(Console.ReadLine());
// int numb2;
// string res = string.Empty;
// string BinaryConverter(int numb10)
// {
// for (; numb10 > 0; numb10 = numb10 / 2)
// {
// numb2 = numb10 % 2;
// res = numb2 + res;
// }
// return res;
// }
// Console.WriteLine(BinaryConverter(numb10));

// Задача 44: Не используя рекурсию, выведите 
// первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8
// void F(int n)
// {
//     int number1 = 0;
//     int number2 = 1;
//     int sup = 0;
//     // Console.WriteLine("F(0) = 0");
//     // Console.WriteLine("F(0) = 1");
//     for (int i = 0; i < n; i++)
//     {
//         Console.WriteLine($"F{(i)} = {number1}");
//         sup = number2;
//         number2 = number2 + number1;
//         number1 = sup;
//     }
// }
// Console.WriteLine("Введите число");
// int N = int.Parse(Console.ReadLine());
// F(N);
// 

// Задача 45: Напишите программу, которая будет 
// создавать копию заданного 
// массива с помощью поэлементного копирования.

// int Func(int c)
// {
//     c = new Random().Next(0, 100);
//     return c;
// }
// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine();
// }
// int[] n = new int[10];
// int[] N = new int[10];
// for (int i = 0; i < n.Length; i++)
// {
//     n[i] = Func(n[i]);
// }
// Print(n);
// Console.WriteLine();
// for (int i = 0; i < n.Length; i++)
// N[i] = n[i];
// Print(N);

