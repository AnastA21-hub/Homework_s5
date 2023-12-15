// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//в которой находится эта точка.
Console.WriteLine("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
if ((X != 0) & (Y != 0))
{
	if ((X > 0) & (Y > 0))
	{
		Console.WriteLine("1 координатная четверть");
	}
	if ((X < 0) & (Y > 0))
	{
		Console.WriteLine("2 координатная четверть");
	}
	if ((X < 0) & (Y < 0))
	{
		Console.WriteLine("3 координатная четверть");
	}
	if ((X > 0) & (Y < 0))
	{
		Console.WriteLine("4 координатная четверть");
	}
}
else
{
	Console.WriteLine("Некорректные коодинаты");
}