// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое целое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if (numberA > numberB)
// {
//     Console.WriteLine("первое число больше");
// }
// if (numberA < numberB)
// {
//     Console.WriteLine("первое число меньше");
// }
// if (numberA == numberB)
// {
//     Console.WriteLine("первое и второе число равны");
// }

// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine("максимальное число: ");
Console.WriteLine(max);
