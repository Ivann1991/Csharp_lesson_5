// Напишите программу замены элементов массива: положительные элементы замените на отрицательные и наоборот.

Console.Clear();

int[] array = GetArray(10, -10, 10);
Console.Write ("[");
for (int i = 0; i < array.Length -1 ; i++)
{
    Console.Write($"{array[i]} ");
}
Console.Write($"{array[array.Length -1]}] ");
Console.Write("--> ");
int [] newarray = zamena(array);

Console.Write ("[");
for (int i = 0; i < newarray.Length -1 ; i++)
{
    Console.Write($"{newarray[i]} ");
}
Console.Write($"{newarray[newarray.Length -1]}] ");






///////////////////////////////////////
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }

    return res;
}

int[] zamena(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array [i] = array[i] * -1;
    return array;
}

