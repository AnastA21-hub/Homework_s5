/*Здайте массив из 10-ти элементов, заполните числами из промежутка от -10 до 10.
Замените отрицательные элементы на положительные, а положительные на отрицательные
Пишем метод для нахождения массива*/
void FillArray(int[] collection)//мето для нахождения массива
{
	int index = 0;
	while (index < collection.Length)
	{
		collection[index] = new Random().Next(-10, 10);
		index++;
	}
}

void PrintArray(int[] col)// метод для вывода массива
{
	int position = 0;//иницилизируем переменную (исполняет роль индекса в печати), куда будут сохранятьcя элементы масива
	while (position < col.Length)// пока выполняется условие, делай так
	{
		Console.Write(col[position] + " ");//выводим элемент массива в консоль
		position++;//переходим к следующей позиции
	}
}

void PositivArray(int[] pos)//создаем метод для изменения знака; в параметрах массив
{
	for (int i = 0; i < pos.Length; i++)//i - индекс
	{
		pos[i] *= -1;//элемент массва с индексом i умножаем на -1
	}
}

int[] array = new int[10];//массиву array присваиваем новый массив длинной 10
FillArray(array);
PrintArray(array);
Console.WriteLine();//пустая строка между массивами
PositivArray(array);
PrintArray(array);