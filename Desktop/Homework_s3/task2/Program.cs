/*Задайте массив на 10 целых чисел. 
Напишите программу, которая определяет количество чётных чисел в массиве.*/
void FillPrintArray(int[] array)//метод для создания и печати массива
{
	int index = 0;
	while (index < array.Length)
	{
		array[index] = new Random().Next(1, 100);
		Console.Write(array[index] + " ");
		index++;
	}
}

int EvenNumbers(int[] array)
{
	int result = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
		{
			result++;
		}
	}
	return result;
}

int[] array = new int[10];
FillPrintArray(array);
Console.WriteLine();
int quantity = EvenNumbers(array);
Console.WriteLine(quantity);
