// Напишите прогамму, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int num1 = number / 100;
int num2 = number % 10;
int result = num1 * 10 + num2;
Console.WriteLine(result);
