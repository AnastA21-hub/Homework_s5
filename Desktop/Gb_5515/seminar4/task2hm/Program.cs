/*Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
int[] FillArray(int size)//инициализируем массив в методе
{
	int[] numbers = new int[size];
	for (int i = 0; i < numbers.Length; i++)
	{
		numbers[i] = new Random().Next(100, 1000);
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

bool IsEven(int num)// метод опрдления четного числа
{
	if (num % 2 == 0)
	{
		return true;
	}
	return false;
}

int GetCountEvenNumber(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (IsEven(array[i]))
		{
			count++;
		}
	}
	return count;
}

int[] list = FillArray(15);
PrintArray(list);
Console.WriteLine();
Console.WriteLine(GetCountEvenNumber(list));