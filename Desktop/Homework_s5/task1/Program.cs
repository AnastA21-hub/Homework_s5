/*Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.*/

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

int[,] list = FillMatrix(7, 7, 1, 20);
PrintMatrix(list);
Console.WriteLine("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());
if(i < list.GetLength(0) || j < list.GetLength(1))
{
	int num = list[i, j];
	Console.WriteLine(num);
}
else
{
	Console.WriteLine($"Такого элемента нет");
}