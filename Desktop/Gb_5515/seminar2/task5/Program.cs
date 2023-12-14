// Напишите программу, которая на вход принимает число и проверяет, кратно ли оно
//одновременно 7 и 23 (да, нет)
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 7 == 0) & (num % 23 == 0))
{
	Console.WriteLine("да");
}
else
{
	Console.WriteLine("нет");
}