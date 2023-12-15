// Вход - цифра дня недели, выход - является ли день выходным (да, нет)
Console.WriteLine("Введите номер дня недели: ");
int weekDay = Convert.ToInt32(Console.ReadLine());
if (weekDay < 8)
{
	if ((weekDay == 6) || (weekDay == 7))
	{
		Console.WriteLine("да");
	}
	else
	{
		Console.WriteLine("нет");
	}
}
else
{
	Console.WriteLine("Некорректное число");
}