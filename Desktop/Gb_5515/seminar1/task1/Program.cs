// Вход - число, выход - квадрат числа
System.Console.WriteLine("Enter number: "); //сначала говорим, что нам нужно
string str = Console.ReadLine();
int num = Convert.ToInt32(str); //конвертер н вход принимает любое число, передаем ему строку, которую получили от пользователя (конвертировать будем из str)
int squere = num * num; //теперь вычисляем квадрат числа (переменная int, которая обозначает squere - квадрат)
System.Console.WriteLine($"squere = {squere}"); //Выводим квадрат числа
