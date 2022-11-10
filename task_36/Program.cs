// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int GetSumFromNotEvenPosition(int[] array)
{
    int sum = 0;
    
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

int[] array = GetRandomArray(10, 0, 100);
InConsoleWriteArray(array);

int sum = GetSumFromNotEvenPosition(array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");