// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 => 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма всех цифр данного числа = " + SumNum(num));

int SumNum (int num, int sum =0)
{
    if (num == 0)
    {
        return sum;
    }
    sum = sum + num % 10;
    num = num / 10;
    return SumNum(num, sum);
}

