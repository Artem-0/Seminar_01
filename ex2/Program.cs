// Задача 2. Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine($"Наибольшее число: {a}; наименьшее число: {b}.");
}
else
{
    System.Console.WriteLine($"Наибольшее число: {b}; наименьшее число: {a}.");
}