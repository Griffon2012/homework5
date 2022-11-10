// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void InConsoleWriteArray(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

int[] GetRandomArray(int countElement, int min, int max)
{
    int[] array = new int[countElement];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

int GetCountEvenNumbers(int[] array)
{
    int countEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEvenNumbers++;
        }
    }

    return countEvenNumbers;
}

int[] array = GetRandomArray(10, 100, 999);
InConsoleWriteArray(array);

int countEvenNumbers = GetCountEvenNumbers(array);

Console.WriteLine($"Количество четных чисел: {countEvenNumbers}");

