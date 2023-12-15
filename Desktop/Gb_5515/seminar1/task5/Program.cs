// Вход - целое трёхзначное число, выход - последняя цифра этого числа
Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);//задаем переменную
if (num > 99 & num < 1000)//проверяем,является ли число трёхзначным
{
	int num2 = num % 10;//остаток целочисленного деления на 10
	Console.WriteLine(num2);
}
else
{
	Console.WriteLine("некорректное число");
}