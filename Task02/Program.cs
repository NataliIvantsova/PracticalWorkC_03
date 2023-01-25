/*Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int Enter(string message) // Фукция ввода задания
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());//возвращаемое значение конверт32 из консоль редлайн
}
double x1 = Enter("введите координату X точки A");
double y1 = Enter("введите координату Y точки A");
double z1 = Enter("введите координату Z точки A");
double x2 = Enter("введите координату X точки B");
double y2 = Enter("введите координату Y точки B");
double z2 = Enter("введите координату Z точки B");

// пишем фукцию вычисления расстояния Distance
double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
double a; 
double b;
double c;
a = x2 - x1;
b = y2 - y1;
c = z2 - z1;
return Math.Sqrt(a*a + b*b+c*c); // функция квадратного корня Math.Sqrt База математических фукций Math
}
System.Console.WriteLine($"Расстояние между двумя точками А и В = {Distance(x1,x2,y1,y2,z1,z2)}"); //сразу выводим то что получилось