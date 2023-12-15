// Вход - два числа, выход - является ли первое квадратом второго
Console.WriteLine("Enter number: ");
string str1 = Console.ReadLine();
Console.WriteLine("Enter number2: ");
string str2 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);
int num2 = Convert.ToInt32(str2);
if (num2 * num2 == num1)// == это оператор сравнения
{
	Console.WriteLine("да");
}
else
{
	Console.WriteLine("нет");
}