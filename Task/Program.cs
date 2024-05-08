﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.
// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

// функция подсчета элементов строки. Если количество элементов меньше или равно 3, то функция запишет элемент
int CountLettersOfElements(string[] array)
{
    int count = 0;
    foreach (string elem in array)
    {
        if (elem.Length <= 3) 
        {
            count++;
        }
    }
    return count;
}
// функция для создания нового массива из слов, удовлетворяющим условию - не более 3 букв)
string[] CreateNewArray(string[] array, int len)
{
    string[] new_array = new string[len];
    int i = 0;
    foreach (string elem in array)
    {
        if (elem.Length <= 3) 
        {
            new_array[i] = elem;
            i++;
        }
    }
    return new_array;
}

//string[] array = {"Russia", "Denmark", "Kazan"};
//string[] array = {"Hello", "2", "world", ":-)"};
string[] array = {"1234", "1567", "-2", "computer science"};

int count = CountLettersOfElements(array);
string[] new_array = CreateNewArray(array, count);


// вывод массива строкой
Console.WriteLine("['" + string.Join("', '", new_array) + "']");
