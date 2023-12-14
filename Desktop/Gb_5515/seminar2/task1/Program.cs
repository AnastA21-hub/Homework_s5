// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа
int number = new Random().Next(10, 100);
Console.WriteLine(number);
int num1 = number / 10;
int num2 = number % 10;
if (num1 > num2)
{
	Console.WriteLine(num1);
}
else
{
	Console.WriteLine(num2);
}