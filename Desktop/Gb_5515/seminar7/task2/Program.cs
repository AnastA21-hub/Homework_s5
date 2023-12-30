/*Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N*/
int GetNumber()//метод ввода числа
{
	Console.WriteLine("Введите число N: ");
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

void listNumber(int number, int start = 1)//метод для вывода чисел
										  //в параметрах указываем start - чило от которого начинаем отсчет
{
	if (start <= number)//базовый случай - когда start будет равен N
	{
		Console.WriteLine(start);//выводим число в консоль
		listNumber(number, start + 1);//
	}
}

int number = GetNumber();
listNumber(number);