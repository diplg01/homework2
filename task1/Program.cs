// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Console.Write("Число равняется: (");
int number = new Random(). Next(100 , 999);
Console.Write($"{number} -->");

int number1 = number / 100;
int number2 = number % 10;
Console.WriteLine($"число без второй цифры = {number1}{number2}");