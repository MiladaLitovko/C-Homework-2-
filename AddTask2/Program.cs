/*Задача 2. На вход подаются год, номер месяца и день рождения человека, 
Определить возраст человека на момент 1 июля 2022 года.*/

Console.WriteLine("Введите число, соответствующее дню рождения человека");
int DayOfBirth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, соответствующее месяцу рождения человека");
int MonthOfBirth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, соответствующее году рождения человека");
int YearOfBirth = Convert.ToInt32(Console.ReadLine());
int CurrentDay = 1;
int CurrentMonth = 6;
int CurrentYear = 2022;

if(MonthOfBirth > CurrentMonth)
{
    Console.WriteLine($"Возраст человека равен: {CurrentYear - YearOfBirth}");
}
else if(DayOfBirth >= CurrentDay &  CurrentMonth == MonthOfBirth)
{
    Console.WriteLine($"Возраст человека равен: {CurrentYear - YearOfBirth}");
}
else
{
    Console.WriteLine($"Возраст человека равен: {CurrentYear - YearOfBirth - 1}");
}