/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
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

int[,] matrix = FillMatrix(5, 7, 10, 100);
PrintMatrix(matrix);
int FindMinNumber(int[,] matrix)//поиск минимального элеменка, выводим индекс строки
{
	int min = matrix[0, 0];
	int rows = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (matrix[i, j] < min)
			{
				min = matrix[i, j];
				rows = i;
			}
		}
	}
	return rows;
}

int index = FindMinNumber(matrix);

System.Console.WriteLine($"Строка с индексом {index}");