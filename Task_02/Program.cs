// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа определяющая максимальное и минимальное целое число");
Console.WriteLine("Введите первое целое число");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numTwo = Convert.ToInt32(Console.ReadLine());

if (numOne > numTwo) {
Console.WriteLine("Максимальное число = " + numOne + ", а минимальное число = " + numTwo);
}
else
{
   Console.WriteLine("Максимальное число = " + numTwo + ", а минимальное число = " + numOne);
}









