// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string rndNum = Convert.ToString(Console.ReadLine());

if (rndNum[2] == rndNum[2])
{
     Console.WriteLine(rndNum[2]);
}
else if (rndNum[1] == rndNum[1])
{
    Console.WriteLine("0");
}

// НЕ смог сообразить какое условие сделать для проверки индексов string



