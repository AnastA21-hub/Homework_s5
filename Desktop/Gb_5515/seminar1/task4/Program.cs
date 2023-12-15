// Вход - целое число N, выход - все целые числа в промежутке от -N до N
Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);
int numStart = num * -1;
while (numStart <= num)
{
	Console.WriteLine(numStart);
	++numStart;//всё равно что numStart=numStart+1
}
