/*Дано натуральное число в диапазоне от 1 до 100 000. 
Создайте массив, состоящий из цифр этого числа. 
Старший разряд числа должен располагаться на 0-м индексе массива, 
младший – на последнем. 
Размер массива должен быть равен количеству цифр.*/
int num = new Random().Next(1, 100000);
/*int num = 548;*/
Console.WriteLine(num);
//определим длину массива
int LengthArray(int number)//метод для определения длины массива
{
	int count = 1;//счетчик для определения количества элементов массива
	while (number >= 10)
	{
		count++;
		number /= 10;
	}
	return count;
}

int length = LengthArray(num);//вызываем метод
Console.WriteLine($"длина массива = {length}");
int[] array = new int[length];//создаем массив
for (int i = array.Length - 1; i >= 0; i--)//ищем элементы массива
{
	array[i] = num % 10;
	num /= 10;
}
foreach (var item in array)//добавляем элементы в массив
{
	Console.Write(item + " ");
}
Console.WriteLine();

