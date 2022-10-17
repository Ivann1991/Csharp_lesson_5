// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

Console.Clear();


int [] newarray = GetArray(10, 100, 999);

PrintArray(newarray);
int even = CountEven(newarray);

Console.WriteLine ("\nКоличество четных чисел в массиве = " + even);

/////////////////////////
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}


void PrintArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}] ");
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count = count + 1;
    }
    return count;
}