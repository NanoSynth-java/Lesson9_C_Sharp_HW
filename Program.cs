// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Введите Число:");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("N = " + n + " -> ");
// int NaturalNumber(int n)
// {
//     if (n == 1)
//     {
//     return 1;
//     }
//     Console.Write(n + ",");
//     return NaturalNumber(n - 1);
// }

// Console.WriteLine(NaturalNumber(n));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int sum = 0;
// int m = InputNumber("Ввод m: ");
// int n = InputNumber("Ввод n: ");

// int InputNumber(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void PrintSum(int m, int n, int sum)
// {
//     sum = sum + n;
//     if (n <= m)
//     {
//         Console.Write($" результат {sum}");
//         return;
//     }
//     PrintSum(m, n - 1, sum);
// }

// Console.Write($"{m}, {n} ->");
// PrintSum(m, n, sum);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int akkermanFunction = Akkerman(m, n);

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");