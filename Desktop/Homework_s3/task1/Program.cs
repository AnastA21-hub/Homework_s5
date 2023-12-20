/*Задайте одномерный массив из 10 целых чисел от 1 до 100. 
Найдите количество элементов массива, значения которых лежат в отрезке [20,90].*/

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

int[] array = new int[10];
FillPrintArray(array);
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
	if ((array[i] >= 20) & (array[i] <= 90))
	{
		count++;
	}

}
Console.WriteLine(count);








