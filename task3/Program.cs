// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7; ");
int nam = Convert.ToInt32(Console.ReadLine());
if (nam > 7) 
{
    Console.WriteLine(" В неделе 7 дней");
}
if(1 == nam) Console.Write(" Понеделик - будний день ");
if(2 == nam) Console.Write(" Вторник - будний день ");
if(3 == nam) Console.Write(" Среда - будний день ");
if(4 == nam) Console.Write(" Четверг - будний день ");
if(5 == nam) Console.Write(" Пятница - будний день "); 
if(6 == nam) Console.Write(" суббота - выходной день ");
if(7 == nam) Console.Write(" воскресенье - выходной день ");
