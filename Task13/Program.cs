//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число");
string number = Console.ReadLine();
Zadacha13(number);


void Zadacha13(string number)
{
    if(number.Length > 2)
    {
        Console.WriteLine(number[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры в числе нет");
    }
}