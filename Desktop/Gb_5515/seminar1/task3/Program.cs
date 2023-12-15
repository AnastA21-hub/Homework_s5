// Вход - число, выход - название дня недели
Console.WriteLine("Enter week day: ");
string weekDay = Console.ReadLine();
int numWeekDay = Convert.ToInt32(weekDay);
if (numWeekDay == 1)
{
	Console.WriteLine("Понедельник");
}
else if (numWeekDay == 2)
{
	Console.WriteLine("Вторник");
}
else if (numWeekDay == 3)
{
	Console.WriteLine("Среда");
}
else if (numWeekDay == 4)
{
	Console.WriteLine("Четверг");
}
else if (numWeekDay == 5)
{
	Console.WriteLine("Пятница");
}
else if (numWeekDay == 6)
{
	Console.WriteLine("Суббота");
}
else if (numWeekDay == 7)
{
	Console.WriteLine("Воскресенье");
}
else
{
	Console.WriteLine("uncorrect week day");
}