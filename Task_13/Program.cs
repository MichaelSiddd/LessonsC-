// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string rndNum = Console.ReadLine();

if (rndNum[2] == rndNum[2]) 
Console.WriteLine($"Третья цифра числа {rndNum} => {rndNum[2]}");
else Console.WriteLine($"У числа {rndNum} нет третьей цифры");
// НЕ смог сообразить какое условие сделать для проверки индексов string



