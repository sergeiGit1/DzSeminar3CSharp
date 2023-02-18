// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numberA;
bool isNumber = int.TryParse(number, out numberA);
if (numberA>=10000 && numberA<=99999)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Число: " + number + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Число: " + number + " не является палиндромом");
    }
}
else if (numberA<0)
{
    Console.WriteLine("Отрицательные числа не являются палиндромами");
}
else
{
    Console.WriteLine("Число не является пятизначным");
}
