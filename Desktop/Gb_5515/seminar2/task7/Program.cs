//Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.
Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)// отсеиваем однозначные числа
{
	Console.WriteLine(N);
}
else
{
	while (N > 0)// пока N>0 делаем так
	{
		int currentDigit = N % 10;//Текущая цифра
		N /= 10;// всё равно что N=N/10
		if (N > 0)
		{
			Console.WriteLine(currentDigit + ",");
		}
		else
		{
			Console.WriteLine(currentDigit);
		}
	}
}