/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

int usernumber;
Console.WriteLine("Введите цифру обозначающюю день недели");
while (!int.TryParse(Console.ReadLine(), out usernumber))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
if (usernumber == 6 || usernumber == 7)
{
	Console.WriteLine("Выходной день");
}
else
{
	Console.WriteLine("Будний день");
}