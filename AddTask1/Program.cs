// Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

Console.WriteLine("Введите число, соответствующее первой стороне треугольника");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, соответствующее второй стороне треугольника");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, соответствующее третьей стороне треугольника");
int numberC = Convert.ToInt32(Console.ReadLine());

if(numberA == numberB || numberA == numberC || numberB == numberC)
{
    Console.WriteLine("Треугольник равнобедренный");
}
else
{
    Console.WriteLine("Треугольник НЕ равнобедренный");
}
