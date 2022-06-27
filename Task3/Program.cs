Console.Write("Введите число для проверки:");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
Console.WriteLine("Число " + number + " четное");
}
else
{
Console.WriteLine("Число " + number + " нечётное");
}