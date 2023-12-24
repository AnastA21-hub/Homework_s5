/*Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)*/

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

void ReversArray(int[] array)
{
	int i = 0;
	int j = array.Length - 1;
	while (i < j)
	{
		int temp = array[i];
		array[i] = array[j];
		array[j] = temp;
		i++;
		j--;
	}
}

int[] list = FillArray(10);
PrintArray(list);
Console.WriteLine();
ReversArray(list);
PrintArray(list);