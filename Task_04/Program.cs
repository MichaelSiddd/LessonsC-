// Задача 4: Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("!Программа определяющая максимальное целое число!");
Console.WriteLine("Введите первое целое число");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int numThree = Convert.ToInt32(Console.ReadLine());
int max = numOne;

if (numTwo > max && numTwo > numThree) {
    max = numTwo;
    Console.WriteLine("Максимальное число = " + max);
}
else if (numThree > max && numThree > numTwo) {
    max = numThree;
    Console.WriteLine("Максимальное число = " + max);
}
else 
{
    Console.WriteLine("Максимальное число = " + max);
}
