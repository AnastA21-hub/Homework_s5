/*Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и
последнюю строку массива.*/
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

void PrintMatrix(int[,] matrix)//метод для вывода двумерного массива
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

void ReversMatrix(int[,] matrix)
{
	int i = 0;
	int j = 0;
	int m = matrix.GetLength(0) - 1;//индекс последней строки
	while (j < matrix.GetLength(1))
	{
		int temp = matrix[i,j];
		matrix[i, j] = matrix[m, j];
		matrix[m, j] = temp;
		j++;
	}
}
int[,] list = FillMatrix(5, 5, 1, 20);
PrintMatrix(list);
ReversMatrix(list);
Console.WriteLine();
PrintMatrix(list);