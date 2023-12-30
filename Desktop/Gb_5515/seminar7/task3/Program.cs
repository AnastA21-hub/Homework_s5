/*Считйте из консоли строку, содержащую латинские буквы.
Вывести на экран согласные буквы этой строки*/
string GetString()
{
	Console.WriteLine("Введите строку: ");
	string str = Console.ReadLine();
	return str;
}

bool IsVowel(char c)//методпоиска гласных
{
	return c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
	return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
}

void PrintString(string str, int index = 0)
{
	if (index < str.Length)
	{
		char c = Char.ToUpper(str[index]);
		if ((c >= 'A' && c <= 'Z') && !IsVowel(c))//! - превращает истину в ложь, а ложь в истину
		{
			Console.Write(c + " ");

		}
		PrintString(str, index + 1);
	}
}

string str = GetString();
PrintString(str);