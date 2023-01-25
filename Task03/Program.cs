/*Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int Enter(string message) // 
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());//возвращаемое значение из консоль редлайн в виде числа
}

int number = Enter("Введите число N ");
//Math.Pow(n,3);// фукция выведения степени в куб, если 3
int i = 1; // индекс равен единице

while(i <= number)
{
    double result = Math.Pow(i,3);
    System.Console.Write($"{result}  ");
    i++;
}