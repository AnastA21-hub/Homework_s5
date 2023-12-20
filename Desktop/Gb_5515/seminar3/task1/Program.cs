/* Задайте программу, которая определяет, присутствут ли заданное число в массиве.
Программа длжна выдавать ответ "да" или "нет".
Т.е. Массив рандомных чисел, вводим число, результат "дА" или "нет"*/
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] list = new int[10];//задаем длину массива

void FillArray(int[] collection)//метод "задаем массив"
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(1, 10);
		index++;
	}
}

void PrintArray(int[] col)//метод для печати массива
{
	int count = col.Length;
	int position = 0;//создаем позицию для вывода элемента массива
	while (position < count)
	{
		Console.Write(col[position] + " ");
		position++;
	}
}

bool FindNumber(int number, int[] array)//метод для поиска числа
{
	for (int i = 0; i < array.Length; i++)
	{
		if (number == array[i])
		{
			return true;
		}
	}
	return false;
}


FillArray(list);//вызываем методпо рандомному заполнению массива
PrintArray(list);//выводим массив

Console.WriteLine();
if (FindNumber(num, list))
{
	Console.WriteLine("Да");
}
else
{
	Console.WriteLine("Нет");
}