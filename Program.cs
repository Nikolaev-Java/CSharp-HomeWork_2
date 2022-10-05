/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int usernumber;
Console.WriteLine("Введите трехзначное число");
while (!int.TryParse(Console.ReadLine(), out usernumber))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine("Вторая цифра числа " + usernumber + ", это - " + (usernumber / 10) % 10);