/*Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива. 
Под удалением понимается создание нового двумерного массива без строки и столбца*/
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

int FindMinRows(int[,] matrix)//поиск строки минимального элемента
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

int FindMinColumns(int[,] matrix)//поиск строки минимального элемента
{
	int min = matrix[0, 0];
	int columns = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (matrix[i, j] < min)
			{
				min = matrix[i, j];
				columns = j;
			}
		}
	}
	return columns;
}

int[,] matrix = FillMatrix(5, 5, 10, 100);
PrintMatrix(matrix);
int[,] matrix1 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
int rows = FindMinRows(matrix);
int columns = FindMinColumns(matrix);
System.Console.WriteLine($"{rows}, {columns}");

for (int i = 0, newI = 0; i < matrix.GetLength(0); i++)
{
	if (i != rows)
	{
		for (int j = 0, newJ = 0; j < matrix.GetLength(1); j++)
		{
			if (j != columns)
			{
				matrix1[newI, newJ] = matrix[i, j];
				++newJ;
			}
		}
		++newI;
	}
}

PrintMatrix(matrix1);