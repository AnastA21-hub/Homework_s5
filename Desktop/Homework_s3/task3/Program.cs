/*Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.*/
void FillArray(double[] array)//метод для создания и печати массива
{
	for (int i = 0; i < array.Length; i++)
	{
		Random rand = new Random();
		double num = rand.Next(1, 100) + rand.NextDouble();
		if (num % 10 != 0)
		{
			array[i] = num;
		}
	}
	foreach (var number in array)
	{
		Console.Write(number + " ");
	}
}
double[] array = new double[10];//задаем размер массива
FillArray(array);//вызываем метод
Console.WriteLine();//пустая строка
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
	if (array[i] > max)
	{
		max = array[i];
	}
	if (array[i] < min)
	{
		min = array[i];
	}
}
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
double difference = max - min;
Console.WriteLine($"разность = {difference}");











