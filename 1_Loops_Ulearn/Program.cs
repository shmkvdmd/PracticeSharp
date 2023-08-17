//Дано N (1 ≤ N ≤ 27). Найти количество трехзначных натуральных чисел, сумма цифр которых равна N.
//Операции деления (/, %) не использовать.
double SumDigits(string iteration)
{
    double count = 0;
    for (int i = 0; i < iteration.Length; i++)
    {
        count += Char.GetNumericValue(iteration, i);
    }
    return count;
}

Console.WriteLine("Введите число от 1 до 27");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 100; i <= 999; i++)
{
    string check = i.ToString();
    if (number == SumDigits(check))
    {
        count++;
        Console.WriteLine(check);
    }
}
Console.WriteLine(count);