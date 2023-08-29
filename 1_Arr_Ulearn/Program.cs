using static System.Console;

int[] array = { 1, 2, 3, 4, 5 };

foreach (var i in MoveArray(array,1))
{
    WriteLine(i);
}
int[] MoveArray(int[] array, int k)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < k; j++)
        {
            (array[j], array[j + 1]) = (array[j + 1], array[j]);
        }
    }
    return array;
}