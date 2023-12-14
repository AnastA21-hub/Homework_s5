// Напишите программу, которая будет принимать на вход два числа и проверять,
//является ли одно из них квадратом другого (да или нет)
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if ((num1 == num2 * num2) || (num2 == num1 * num1))
{
	Console.WriteLine("да");
}
else
{
	Console.WriteLine("нет");
}
