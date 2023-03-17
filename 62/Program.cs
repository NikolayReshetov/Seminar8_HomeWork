// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// ==== решена не до конца ======


using System;
using static System.Console;

int [,] array = new int[4, 4];

WriteLine("0-й Массив:");
PrintArray(array);

WriteLine("Заполненный массив:");
PrintArray(PullArray(array));

int[,] PullArray (int[,] array){

    int row = 0;
    int col = 0;
    for (int i = 1; i < ( array.GetLength(0) * array.GetLength(1) + 1); i++){
        if (array[row, col] == 0) array[row, col] = i;
        
        if (col + 1 < array.GetLength(0) && array[row,col+1] == 0  ){ 
            col = col + 1;
            continue;}

        if (row + 1 < array.GetLength(1) && array[row+1,col] == 0 ){
            row = row + 1;
            continue;}

        if (col - 1 >= 0 && array[row,col-1] == 0 ){  
            col = col - 1;
            continue;}

        if (row - 1 >= 0 && array[row-1,col] == 0 ){
            row = row - 1;
            continue;}  
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