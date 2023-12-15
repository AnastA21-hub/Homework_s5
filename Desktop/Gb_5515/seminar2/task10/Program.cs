// Вход - трехзначное число, выход - вторая цифра этого числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 99) & (number < 1000))
{
	int num = number / 10;
	int num2 = num % 10;
	Console.WriteLine(num2);
}
else
{
	Console.WriteLine("Некорректное число");
}