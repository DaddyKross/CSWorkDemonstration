﻿//Поставлена задача:
//Написать программу, которая из имеющегося массива строк формирует новый массив,
//который состоит из строк по длине меньше или равной 3 символам.
//Исходный массив можно ввести вручную, либо задать на начальном этапе алгоритма.
//При решении задачи лучше работать только с массивами.
//Примеры:
//["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//["1234", "1567", "-2", "computer science"] -> ["-2"]
//["Russia", "Denmark", "Kazan"] -> []

using System;

class ProgramFinal
{
    static void Main()
    {
        int arraySize = RequestArraySize();
        string[] inputStrings = ReadInputStrings(arraySize);
        string[] SuitableStrings = FilterStrings(inputStings);
        DisplayResults(inputStrings, SuitableStrings);
    }

    static int RequestArraySize()
    {
        Console.Write("Введите количество строк в массиве: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    
}