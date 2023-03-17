// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

WriteLine("Первый массив:");
int [,] array1 = GetArray(2, 2);
PrintArray(array1);

WriteLine("Второй массив:");
int [,] array2 = GetArray(2, 2);
PrintArray(array2);

WriteLine("Производный массив:");
PrintArray( ArrayMulti(array1, array2) );

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

int[,] ArrayMulti (int[,] array1, int[,] array2){
    if (array1.GetLength(0) != array2.GetLength(1)){
        WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }
    int[,] arrayMulti = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++){
        for (int j = 0; j < array2.GetLength(1); j++){
            arrayMulti[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++){
                arrayMulti[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return arrayMulti;
}