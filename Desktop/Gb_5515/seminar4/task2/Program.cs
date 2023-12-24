/*Задайте массив из N случайных чисел (N вводим с клавиатуры).
Найдите колчество чисел, которые заканчиваются на 1 и делятся нацело на 7.*/
int[] FillArray(int size)//инициализируем массив в методе
{
	int[] numbers = new int[size];
	for (int i = 0; i < numbers.Length; i++)
	{
		numbers[i] = new Random().Next(1, 100);
	}
	return numbers;
}

void PrintArray(int[] num)//метод вывода массива в консоль
{
	for (int i = 0; i < num.Length; i++)
	{
		Console.Write(num[i] + " ");
	}
}

bool IsCheck(int num)//метод по определнию соответствия числа условию
{
	return ((num % 7 == 0) && (num % 10 == 1));
}
/*если условие выполнится, то bool вернет true.
Если не выполнится, то false
&& - два амперсанта - это логическое действие - если выполняетя первое условие
только тогда  будет проверяться второе.*/

int GetCount(int[] array)//метод поиска элементов массива, соответствующих условию
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (IsCheck(array[i]))
		{
			count++;
		}
	}
	return count;
}
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] list = FillArray(size);
PrintArray(list);
Console.WriteLine();//пустая строка
Console.WriteLine(GetCount(list));