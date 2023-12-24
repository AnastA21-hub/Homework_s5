/* Задайте одномерный массив, заполните случайными числами.
Определите количество простых чисел в этом массиве
Пример [1 3 4 19 3] => 2
Простые числа - это числа, которые делятся только на себя и на единицу*/
void FillArray(int[] collection)//метод для нахождения элементов массива
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(1, 100);
		index++;
	}
}

void PrintArray(int[] col)//метод для вывода массива в консоль
{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.Write(col[position] + " ");
		position++;
	}
}

bool IsPrime(int num)//метод по нахождению числа (не в массиве)
{
	for (int i = 2; i < num; i++)//i - любое число, начиная с двух
	{
		if (num % i == 0)//если число делится на любое число из отрезка (2; num) без остатка
		{
			return false;//то это уже непростое число
		}
	}
	return true;
}

int GetCountPrimeNumber(int[] array)// метод для поиска чисел, соответствующих методу IsPrime, в массиве
{
	int count = 0;//вводим переменную для посчета количества
	for (int i = 0; i < array.Length; i++)//перебираем элементы массива
	{
		if (IsPrime(array[i]))//вызываем метод IsPrime
		{
			count++;//если элемент соответсвует условию в методе IsPrime, то count суммируется
		}
	}
	return count;
}

int[] list = new int[10];//задаем размер массива
FillArray(list);//вызываем метод поика массива
PrintArray(list);//вызываем метод вывода массива
Console.WriteLine();//пустая строка
int number = GetCountPrimeNumber(list);//вызываем метод
Console.WriteLine(number);//выводим результат в консоль