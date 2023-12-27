/*Задайте двумерный массив из целых чисел.
Сформируйте новый одномерный массив, состоящий из среднеарифмеического
значения по строкам двумерного массива*/
int[,] FillMatrix(int rows, int columns, int minValue, int maxValue)
{
	int[,] matrix = new int[rows, columns];
	Random rand = new Random();
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			matrix[i, j] = rand.Next(minValue, maxValue);
		}
	}
	return matrix;
}
void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write(matrix[i, j] + " ");
		}
		Console.WriteLine();
	}
}

int[,] list = FillMatrix(5, 5, 0, 10);//инициализируем двумерный массив
PrintMatrix(list);
Console.WriteLine();
int[] array = new int[list.GetLength(0)];/*инициализируем одномерный массив
длина массива равна количесву строк в двумерном массиве*/
int sum = 0;
for (int i = 0; i < list.GetLength(0); i++)
{
	for (int j = 0; j < list.GetLength(1); j++)
	{
		sum = sum + list[i, j];
	}
	array[i] = sum / list.GetLength(1);//индекс водномерном массиве совпадает с исходным
}
Console.WriteLine($"[{String.Join(", ", array)}]");



