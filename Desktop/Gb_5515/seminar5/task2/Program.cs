/*Задайте двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали.
Главная диагональ - когда i=j (rows = columns)*/
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
int SumNumbers(int[,] matrix)//метод для суммирования элементов главной диагонали
{
	int sum = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (i == j)
			{
				sum = sum + matrix[i, j];
			}
		}
	}
	return sum;
}


int[,] list = FillMatrix(5, 5, 0, 10);
PrintMatrix(list);
int sum = SumNumbers(list);
Console.WriteLine(sum);