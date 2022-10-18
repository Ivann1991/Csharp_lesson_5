//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

Console.Clear();

double[] newarray = GetArray(5);

PrintArray(newarray);

double raznostMaxMin = Math.Round(MaxMinIndex(newarray),2);

Console.Write($"\nразница между максимальным и минимальным элементом массива равна {raznostMaxMin}");


/////////////////////////

double[] GetArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return array;
}

double MaxMinIndex(double[] array)
{
    double MinIndex = array[0];
    double MaxIndex = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinIndex)
            MinIndex = array[i];
        if (array[i] > MaxIndex)
            MaxIndex = array[i];
    }
    double a = MaxIndex - MinIndex;
    return a;
}

void PrintArray(double[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}] ");
}