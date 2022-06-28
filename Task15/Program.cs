/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/


Console.WriteLine("Введите число, соответсвующее дню недели");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 6 || number ==7)
{
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Это будний день");
}