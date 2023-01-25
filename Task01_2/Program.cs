/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
14212 -> нет
12821 -> да
23432 -> да*/

int Enter(string messege)
{
    System.Console.Write(messege);//введите сообщение
    int x = Convert.ToInt32(Console.ReadLine());//значению х = прочитать строку
    return x;//вывести значение х из предыдущей строки
}
int num = Enter("Введите число > ");
int original = num;
int rev = 0;
while(num>0)
{
    int a = num % 10;
    rev = rev*10+a;
    num = num/10;
}
if(original==rev)
{
    System.Console.WriteLine($"Число {original} - палиндром");
}
else
{
    System.Console.WriteLine($"Число {original} - НЕ палиндром");
}
// не смогла записать его через фукцию. показать как правильно её записать