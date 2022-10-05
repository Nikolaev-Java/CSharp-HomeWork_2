/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

int usernumber;
Console.WriteLine("Введите число");
while (!int.TryParse(Console.ReadLine(), out usernumber))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
if (usernumber > 99)
{
	while (usernumber > 999)
	{
		usernumber = usernumber / 10;
	}
	Console.WriteLine("Третья цифра - " + usernumber % 10);
}
else
{
	Console.WriteLine("Нет третьей цифры");
}