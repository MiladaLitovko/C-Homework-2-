/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/


Console.WriteLine("Введите число, соответствующее дню недели");
int number = Convert.ToInt32(Console.ReadLine());
Zadacha15(number);


void Zadacha15(int number)
{
    if(number == 6 || number ==7)
    {
        Console.WriteLine("Это выходной");
    }
    else if(number < 1 || number > 7)
    {
        Console.WriteLine("Это число не соответствует дню недели");
    }
    else
    {
        Console.WriteLine("Это будний день");
    }
}