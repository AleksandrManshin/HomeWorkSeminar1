Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
Console.WriteLine("Первое число " + numberA + " больше второго числа " + numberB);
}
if(numberA < numberB)
{
Console.WriteLine("Второе число " + numberB + " больше первого числа " + numberA);
}
if(numberA == numberB)
{
Console.WriteLine("Первое число " + numberA + " равно второму числу " + numberB);
}