/*Напишите программу, которая на вход принимает число и возвращает сумму его цифр*/

int GetNumber()//метод ввода числа с консоли
{
	Console.WriteLine("Введите число: ");
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

int FindSum(int number)//считаем сумму чисел с помощью рекурсии
{
	if (number == 0)//базовый случай - после деления на 10 number = 0
	{
		return 0;
	}
	//если условие не выполняется, то сумма вычисляется
	int sum = number % 10 + FindSum(number / 10);
	return sum;
}

int number = GetNumber();
int sum = FindSum(number);
Console.WriteLine(sum);