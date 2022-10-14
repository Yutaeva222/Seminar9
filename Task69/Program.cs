// Задача 69. Напишите программу, которая на вход принимает два числа А и В, и возводит число 
// А в целую степень В с помощью рекурсии.

// Решение через цикл
int a = 5;
int b = 4;
int result = 1;

// for (int i = 0; i < b; i++) // при каком условии работаем 
// {
//     result *= a;
// }
// Console.WriteLine("А в степени В = " + result);

Pow (a, b);

void Pow(int a, int b, int result = 1)
{
    if (b == 0) // при каком условии завершаем работу
    {
        Console.WriteLine("А в степени В = " + result);
        return;
    }
    result *= a;
    b--;
    Pow(a, b, result);
}

