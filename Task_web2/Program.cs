

int rndNum = new Random().Next(10, 100);//случайное число
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");

int firstDigit = rndNum / 10;
int secondDigit = rndNum % 10;
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");

// int maxDigit = firstDigit;
// if (secondDigit > maxDigit) maxDigit = secondDigit;
// else if (secondDigit == firstDigit) maxDigit = 0;
// if (maxDigit >0) Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");
// else Console.WriteLine($"Цифры числа {rndNum} равны");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "Числа равны";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");


int num = new Random().Next(200, 700);
int num1 = num / 100;
int num3 = num % 10;
int result = num1 * 10;

