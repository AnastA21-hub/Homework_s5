// Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. Если второе число некратно первому,
//то программа выводит остаток от деления
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num1 % num2;
if (num3 == 0)
{
	Console.WriteLine("кратно");
}
else
{
	Console.WriteLine($"не кратно, остаток {num3}");
}