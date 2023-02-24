// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Ввод первоначального массива
string[] CreatingArray()
{
    string input;
    string[] array;
    input = Console.ReadLine()!;
    array = input.Split(" ");
    return array;
}

// Формирование массива из строк, длина которых меньше либо равна 3 символа
string[] CreatingLimitedArray(string[] array)
{
    int count = 0, j = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i].Length < 4)
            count++;
    }
    
    string[] limitedArray = new string[count];

    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i].Length < 4)
            {
                limitedArray[j] = array[i];
                j++;
            }
    }
    return limitedArray;
}