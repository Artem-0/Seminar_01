// Задача 8. Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= N; i +=2)
{
    System.Console.Write(i);
    System.Console.Write(' ');
}