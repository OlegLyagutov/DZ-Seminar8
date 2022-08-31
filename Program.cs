// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] GetArray(int m, int n)
// {
// int[,] matrix = new int[m, n];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(11);
// }
// }
// return matrix;
// }

// void PrintArray(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write(matrix[i, j] + "\t");
// }
// Console.WriteLine();
// }
// }

// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] SortingArray(int[,] matrix)
// {
//     int[,] elementsArray = new int[matrix.GetLength(0), matrix.GetLength(1)];

//     int max = elementsArray[0,0];


//     // int[,] ChangeElements(int[,] matrix)
//     // {
//     //     int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < elementsArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < elementsArray.GetLength(1); j++)
//         {
//             if (elementsArray[i, j] > max)
//             {
//                 max = elementsArray[i, j];
//             }

//         }
//     }
//     return elementsArray;
// }

// int[,] elementstMatrix = GetArray(rows, columns);
// PrintArray(elementstMatrix);
// Console.WriteLine("Результат: ");
// PrintArray(SortingArray(elementstMatrix));

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new  int[rows, columns];
// int[] sumRows = new int[rows];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array[i, j] = new Random().Next(11);
//         sumRows[i] += array[i, j];
//         Console.Write(array[i, j] + "\t");
//     }
//     Console.WriteLine($"Сумма {i + 1} строки равна: {sumRows[i]}");
//     Console.WriteLine();
// }

// int minSumRows = sumRows[0];
// int minIndexRows = 0;
// for (int j = 0; j <= rows; j++) 
// {
//     for (int i = 0; i < rows; i++)
//     {
//         if (sumRows[i] < minSumRows)
//         {
//             minSumRows = sumRows[i];
//             minIndexRows = i;
//         }    
//     }
// Console.WriteLine($"Наименьшая сумма элементов: {minIndexRows + 1} строка"); 
// return;   
// }    



// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rowsFirst = Convert.ToInt32(Console.ReadLine());
int columnsFirst = Convert.ToInt32(Console.ReadLine());
int rowsSecend = Convert.ToInt32(Console.ReadLine());
int columnsSecend = Convert.ToInt32(Console.ReadLine());

int[,] matrixFirst = new  int[rowsFirst, columnsFirst];

for (int i = 0; i < rowsFirst; i++)
{
    for (int j = 0; j < columnsFirst; j++)
    {
        matrixFirst[i, j] = new Random().Next(11);
        Console.Write(matrixFirst[i, j] + "\t");
    }
    // Console.WriteLine($"Сумма {i + 1} строки равна: {sumRows[i]}");
    Console.WriteLine();
}
Console.WriteLine();

int[,] matrixSecend = new  int[rowsSecend, columnsSecend];

for (int m = 0; m < rowsSecend; m++)
{
    for (int n = 0; n < columnsSecend; n++)
    {
        matrixSecend[m, n] = new Random().Next(11);
        Console.Write(matrixSecend[m, n] + "\t");
    }
    //Console.WriteLine($"Сумма {i + 1} строки равна: {sumRows[i]}");
    
    Console.WriteLine();
}
int rowsNew = Convert.ToInt32(Console.ReadLine());
int columnsNew = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = new int[rowsFirst * rowsSecend, columnsFirst * columnsSecend];

// for (int k = 0; k < rowsNew; k++)
// {
//     for (int f = 0; f < columnsNew; f++)
//     {
//         // newMatrix[k, f] =  matrixFirst[i, j] * matrixSecend[m, n];
        
//         newMatrix[k, f] =  matrixFirst[i, j] * matrixSecend[m, n];
//         Console.Write(matrixSecend[k, n] + "\t");
//     }
//Console.WriteLine($"Результирующая матрица будет: {newMatrix[k, f]}");


Console.Write(newMatrix);



// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int depth = Convert.ToInt32(Console.ReadLine());
// int[,,] array = new  int[rows, columns, depth];


// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         for (int k = 0; k < depth; k++)
//         {
//             array[i, j, k] = new Random().Next(100);
//             Console.WriteLine($"{array[i, j, k]} {(i,j,k)} ");
//         }
//     }
//     Console.WriteLine();
// }

// Задача 62. Напишите программу, которая заполнит спирально 
// массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


