/*Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, 
сумма цифр которого чётная.*/
//сначала надо метод по определению числа условию


bool IsEven(int num)//сумма цифр числа четная
{
	int sum = (num % 10) + (num / 10);
	if (sum % 2 == 0)
	{
		return false;
		stop;
	}
	return true;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number = IsEven(number))
{
	Console.WriteLine("Введите число: ");
	number = Convert.ToInt32(Console.ReadLine());
}