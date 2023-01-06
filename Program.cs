// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// int[] CreateArray(int size, int min, int max){
//     int [] array = new int [size];
//     for(int i = 0; i<size; i++){
//         array[i]= new Random().Next(min, max+1);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" { array[i] } ");
//     }
//     Console.WriteLine();
// }

// int [] CountArray(int [] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]>0)
//         {
//             count++;
//         }
//     }
//     Console.Write($"{count} елементов больше 0: -> ");
//     return array;
// }
// Console.Write($"Enter array number: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Enter array min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Enter array max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateArray(size, min, max);
// ShowArray(array);
// int [] count = CountArray(array);
// ShowArray(count);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Console.Write("Enter b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;
// Console.WriteLine($"Пересечение в точке: ({x};{y})");
