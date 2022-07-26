// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

// int newnub1 = 0;

// for (int i = 0; i < n; i++)
// {
//     // Console.WriteLine(mass[0,i]);
//     // Console.Write(mass[m - 1, i]);
//     newnub1 = mass[0,i];
//     mass[0,i] = mass[m - 1, i]; 
//     mass[m - 1, i] = newnub1;
// }
// Print(mass);

// Задача 55: Задайте двумерный массив. Напишите программу, которая 
// заменяет строки на столбцы. 
// В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.


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
// int m = 4, n = 4;
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

// if (m != n)
// {
//     Console.WriteLine("Невозможно поменять строки и столбцы местами");
// }


// int newnub1 = 0;

// for (int i = 0; i < m; i++)
// {
//     for (int j = i + 1; j < n; j++)
//     {
//         newnub1 = mass[i,j];
//         mass[i,j] = mass[j,i]; 
//         mass[j,i] = newnub1;
        
//     }
// }

// Print(mass);


// Задача 57: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит 
// информацию о том, 
// сколько раз встречается элемент входных данных.


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

Random random = new Random();
int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mass[i, j] = random.Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

int [] array = new int[mass.Length];
int k = 0;
bool finded = false;
for (int i = 0; i < m; i++)
{
    for (int i = 0; i < length; i++)
    {
        
    }
}
