// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

using System;
using static System.Console;

int [,] array = GetArray(4, 4);
PrintArray(array);

WriteLine();

Write($"Строка с наименьшей суммой элементов № {FindMinRowInArray(array)}");

int[,] GetArray (int m, int n){
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i, j] = new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Write($"{array[i, j]}  ");
        }
    WriteLine();
    }
}

int FindMinRowInArray (int [,] array){
    int minRow = 0;
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++){
        sum += array[0, j];
    }
    int minSum = sum;

    for (int i = 1; i < array.GetLength(0); i++){
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum += array[i, j];
        }
        if (sum < minSum) minRow = i; 
    }
    return minRow+1;
}