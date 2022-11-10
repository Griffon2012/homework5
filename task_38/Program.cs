// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InConsoleWriteDoubleArray(double[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

double[] GetRandomArrayDouble(int countElement, int min, int max)
{
    double[] array = new double[countElement];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(((rnd.NextDouble() * (max - min)) + min), 2);
    }

    return array;
}

double GetDiffMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length ; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        
        if (min > array[i])
        {
            min = array[i];
        }
    }

    return max - min;
}

double[] array = GetRandomArrayDouble(10, 0, 100);
InConsoleWriteDoubleArray(array);

double diff = GetDiffMaxAndMin(array);
Console.WriteLine($"Разница максимального и минимального элемента: {diff}");