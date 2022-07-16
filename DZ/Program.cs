// Задача 41: Пользователь вводит с клавиатуры M 
// чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.Write("Введите кол-во чисел: ");
// int M = int.Parse(Console.ReadLine());
// int count = 0;

// int[] arr = new int[M];
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"Число {i + 1} = ");
//     arr[i] = int.Parse(Console.ReadLine());

//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");


// Задача 43. Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, 
// k2 = 9 -> (-0,5; 5,5)

// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());
// var x = -(b1 - b2) / (k1 - k2);
// var y = k1 * x + b1;
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
// Console.WriteLine($"Пересечение в точке: ({x};{y})");


// Задача 43. Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, 
// k2 = 9 -> (-0,5; 5,5)

// Console.Write("Введите k1: ");
// double k1 = double.Parse(Console.ReadLine());
// Console.Write("Введите b1: ");
// double b1 = double.Parse(Console.ReadLine()); // double.Parse
// Console.Write("Введите k2: ");
// double k2 = double.Parse(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = double.Parse(Console.ReadLine());
// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;
// x = Math.Round(x, 2);
// y = Math.Round(y, 2);
// Console.WriteLine($"Пересечение в точке: ({x};{y})");
