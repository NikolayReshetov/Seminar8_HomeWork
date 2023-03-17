// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;

int [,] array = GetArray(4, 4);
PrintArray(array);

WriteLine();

PrintArray(ChangeArray(array));

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

int[,] ChangeArray (int [,] array){
    int[,] changeArray = array;
    for (int i = 0; i < changeArray.GetLength(0); i++){
        for (int j = 0; j < changeArray.GetLength(1); j++){
            for (int k = j+1; k < changeArray.GetLength(1); k++){
                if (changeArray[i,k] > changeArray[i,j]){
                    int temp = changeArray[i,k];
                    changeArray[i,k] = changeArray[i,j];
                    changeArray[i,j] = temp;
                }
            }
        }
    }
    return changeArray;
}