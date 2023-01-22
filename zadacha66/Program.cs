// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.WriteLine("Ввведите M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввведите N");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = M; i <= N; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine(sum);


// решение с рекурсией
Console.WriteLine("Введите M : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N : ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum(int M, int N)
{
    if (N == M) return M;
    return N + Sum(M, N - 1);
}
Console.WriteLine(Sum(M, N));
