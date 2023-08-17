// В массиве чисел найдите самый длинный подмассив из одинаковых чисел.

int[] array = ArrayGenerator(20, 1, 2);
List<int> multiplynumber = new List<int>();
int maxCount = 1;
var arrayNumber = 0;
int max = 1;
for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] == array[i + 1])
    {
        max++;
    }
    else max = 1;
    if (max > maxCount)
    {
        maxCount = max;
        arrayNumber = (int)array.GetValue(i);
    }

}
for (int i = 0; i < maxCount; i++)
{
    multiplynumber.Add(arrayNumber);
}

int[] answer = multiplynumber.ToArray();

Console.WriteLine("Изначальный массив: ");
WriteArray(array);

Console.WriteLine($"\n\nПовторяющееся число: {arrayNumber} | Повторяется раз: {maxCount}");

Console.WriteLine("\nПодмассив повторяющихся чисел: ");
WriteArray(answer);

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] ArrayGenerator(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
