// вход - число. Выход - третья цифра заданного числа либо что ее нет
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 99))
{
	if ((number > 99) & (number < 1000))
	{
		number %= 10;
		Console.WriteLine(number);
	}
	while (number > 99)
	{
		number /= 10;
		if ((number < 1000) & (number > 99))
		{
			number = number % 10;
			Console.WriteLine(number);
		}
	}
}
else
{
	Console.WriteLine("третьей цифры нет");
}