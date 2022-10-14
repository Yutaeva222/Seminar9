 // Задача 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
 // в промежутке этих чисел.

  
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
FindNatural(N,M);
void FindNatural(int N, int count = 1)
{
   
    Console.Write(count + " ");
    count++;
    if (count >= N)
    {
        return;
    }
    FindNatural(N, count);
}
