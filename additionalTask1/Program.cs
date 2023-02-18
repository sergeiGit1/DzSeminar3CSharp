// Доп. задание №1:
// Представим банк, в котором алгоритм начисления процента по вкладу 
// зависит от суммы вклада. На вход будет подаваться число (сумма вклада). 
// При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне 
// от ста до двухсот — 7 %, если больше — 10 %. Отработав, программа должна вывести 
// общую сумму с начисленными процентами.
Console.WriteLine("Введите сумму вклада: ");
double depAmount = Convert.ToInt32(Console.ReadLine());
double addSum = 0;
if (depAmount <= 100)
{
    addSum = (depAmount / 100) * 5;
    Console.WriteLine($"Общая сумма: {depAmount + addSum}");
}
else if (depAmount >= 100 && depAmount <= 200)
{
    addSum = (depAmount / 100) * 7;
    Console.WriteLine($"Общая сумма: {depAmount + addSum}");
}
else if (depAmount >= 200)
{
    addSum = (depAmount / 100) * 10;
    Console.WriteLine($"Общая сумма: {depAmount + addSum}");
}

