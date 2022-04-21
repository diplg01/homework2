// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Число равняется: (");
int number = new Random(). Next(1 , 300);
Console.Write(number);
if (number < 100)
{
    Console.WriteLine(") Третьей цифры нет!!!");
}
else
{
    Console.WriteLine($") Третья цифра числа {number % 10}");
}