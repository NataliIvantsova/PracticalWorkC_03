/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите число: ");
string number = Console.ReadLine();

int b = Convert.ToInt32(number);

void ProverkaNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"число: {number} - палиндром.");
    }
    else Console.WriteLine($"число: {number} - НЕ палиндром.");
}

if (b > 10000 && b < 100000)
{
    ProverkaNumber(number);
}
else Console.WriteLine($"Число не пятизначное");
