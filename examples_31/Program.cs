// Задайте массив из 12 эелементов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных и положительных элемнтов массива.
int[] array = GetArray(12, -9, 9);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int negativeSum = GetNegativeSum(array);
Console.WriteLine($"\nСумма отрицательных чисел равна {negativeSum}");

int positiveSum = GetPositiveSum(array);
Console.WriteLine($"\nСумма положительных чисел равна {positiveSum}");


int GetPositiveSum(int[] array)
{
    int positiveSum = 0;
    foreach(int el in array)
    {
        if(el>0) positiveSum+=el;
    }
    return positiveSum;
}


int GetNegativeSum(int[] array)
{
    int negativeSum = 0;
    foreach(int el in array)
    {
        if(el<0) negativeSum+=el;
    }
    return negativeSum;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }

    return res;
}
