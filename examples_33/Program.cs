// Задайте массив. Напишите программу которая определяет присутствует ли заданное число в массиве. 

int[] array = GetArray(10, -10, 10);

int usernumber = usernum("Введи целое число ", "Ошибка ввода");

PrintArray(array);



///////////////////////////////////////
int usernum(string Message, string errorMessage)
{
    while (true)
    {
        Console.Write(Message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect)
            return num;
        Console.WriteLine(errorMessage);
    }
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

void PrintArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}] ");
}

foreach (int el in array)
{
    if (el == usernumber)
    {
        Console.WriteLine(" В сгенерированном массиве ");
        PrintArray(array);
        Console.Write($"Присутсвует число {usernumber} ");
        break;
    }

}
