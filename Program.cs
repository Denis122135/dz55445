//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void FillArray(int[] array)
// {
//     for (int  i= 0; i < array.Length; i++)
//         array[i] = new Random().Next(99,1000);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// int FindEven(int[] array)
// {
//     int even = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//     if (array[i] % 2 == 0) 
//         even = even + 1;
//     }
//     return even;
// }

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Количество четных чисел {FindEven(array)}");






//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// void FillArray(int[] array)
// {
//     for (int  i= 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100,100);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// int FindSum (int[] array)
// {
//     int sum = 0;
//     for (int  i= 0; i < array.Length; i++)
//     if (i % 2 == 1)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Сумма чисел на нечетных позициях равна {FindSum(array)}");





// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// void FillArray(double[] array)
// {
//     for (int  i= 0; i < array.Length; i++)
//         array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
// }

// void PrintArray(double[] array)
// {
//     foreach (double item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// double FindMax (double[] array)
// {
//     double max = array[0];
//     for (int  i= 0; i < array.Length; i++)
//     if (array[i] > max)
//     {
//         max = (array[i]);
//     }
//     return max;
// }

// double FindMin (double[] array)
// {
//     double min = array[0];
//     for (int  i= 0; i < array.Length; i++)
//     if (array[i] < min)
//     {
//         min = Convert.ToDouble(array[i]);
//     }
//     return min;
// }

// void FindDifferenceMaxMin (double[] array)
// {
//     double result = FindMax(array) - FindMin(array);
//     Console.WriteLine($"Разница между максимальным и минимальным равна {result}");
// }


// double[] array = new double[20];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Максимальное число {FindMax(array)}");
// Console.WriteLine($"Минимальное число {FindMin(array)}");
// FindDifferenceMaxMin(array);


