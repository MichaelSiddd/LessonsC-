// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трехзначное число");
int rndNum = Convert.ToInt32(Console.ReadLine());

int secondDigit = (rndNum % 100) / 10;

Console.WriteLine("Его второе число = " + secondDigit);









