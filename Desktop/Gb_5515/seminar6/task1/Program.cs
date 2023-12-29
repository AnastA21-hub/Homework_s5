/*Задайте массив символов тип []char, создайте строку из символов этого массива
Укзание Конструктор строки вида string(char[]) не использовать
Пример ['a', 'b', 'c', 'd'] => "abcd"*/


using System.Text;
{
	char[] arr = { 'a', 'b', 'c', 'd' };//создаем массив тип char
	string str = "";
	StringBuilder strB = new StringBuilder();//этот класс выделяет память под себя
	for (int i = 0; i < arr.Length; i++)
	{
		strB.Append(arr[i]);
	}
	System.Console.WriteLine(strB);
}

