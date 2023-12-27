/*Задайте двумерный массив. Найдите элементы, у которых об индекса четные,
и замените на их квадраты*/
/*создадим метод, который заполнит массив рандомными числами
будем принимать размер массива, а возвращать массив*/
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
void FindIndex(int[,] matrix)//метод, где оба индекса четные, получаем квадрат элемента
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (i % 2 == 0 && j % 2 == 0)
			{
				matrix[i, j] = matrix[i, j] * matrix[i, j];
			}
		}
	}
}


int[,] matrix = FillMatrix(5, 5, 0, 10);//инициализируем массив
PrintMatrix(matrix);
Console.WriteLine();
FindIndex(matrix);
PrintMatrix(matrix);