// Задача 63: Задайте значение вещественное N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
FindNatural(number);
void FindNatural(int number, int count = 0)
{
    count++;
    Console.Write(count + " ");
    if (count >= number)
    {
        return;
    }
    FindNatural(number, count);
}
