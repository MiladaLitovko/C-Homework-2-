/*
Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер 
вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев. */

Console.WriteLine("Введите кол-во месяцев");
int months = Convert.ToInt32(Console.ReadLine());
int count = 1;
double number = 1000;

while(count<months)
{
    number = number + number * 0.015;
    count ++;
}
Console.WriteLine($"Размер депозита равен {number}");