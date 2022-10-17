// Задайте массив заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
Console.Clear();

int[] newarray = GetArray(11, -100, 100);
Console.Write("В сгенерированном массиве -> ");
PrintArray(newarray);
int a = SumUnevenPosition(newarray);
Console.Write("cумма элементов нечетных позиций = " + a);

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

int SumUnevenPosition(int[] array)
{
    int SumUneven = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        SumUneven = array[i] + SumUneven;
    return SumUneven;
}